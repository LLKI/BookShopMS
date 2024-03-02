using Sunny.UI;
using System.Data;
using System.Data.SqlClient;
namespace BookShop
{
    public partial class Billing : UIForm
    {
        public Billing()
        {
            InitializeComponent();
            LoadBookGrid();
        }

        private void LoadBookGrid()
        {
            string sql = "select * from BookTb1";
            SqlDataAdapter data = DBHelper.SelectForDataReader(sql);
            if (data != null)
            {
                var ds = new DataSet();
                data.Fill(ds);
                BookDGV.DataSource = ds.Tables[0];
                BookDGV.Refresh();
            }
            else
            {
                UIMessageBox.Show("查询失败！");
            }
        }

        public void Reset()
        {
            txtBookName.Text = "";
            txtBookPrice.Text = "";
            txtBookCount.Text = "1";
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        int stock = 0;//库存
        private void BookDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBookName.Text = BookDGV.SelectedRows[0].Cells[1].Value.ToString();
            txtBookPrice.Text = BookDGV.SelectedRows[0].Cells[5].Value.ToString();
            txtBookCount.Text = "1";
            stock = Convert.ToInt32(BookDGV.SelectedRows[0].Cells[4].Value.ToString());
        }

        int n = 1, GoldTotal = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int newAddBookCount = Convert.ToInt32(txtBookCount.Text);
            if (txtBookCount.Text == "" || newAddBookCount > stock)
            {
                UIMessageBox.Show("库存不足！");
            }

            else
            {
                int total = newAddBookCount * Convert.ToInt32(txtBookPrice.Text);
                foreach (DataGridViewRow row in ShopDGV.Rows)
                {
                    if (row != null && row.Cells[1].Value != null)//书已经存在于购物车中，判断库存是否足够再考虑是否添加
                    {
                        if (row.Cells[1].Value.ToString().Contains(txtBookName.Text))
                        {
                            int ShopBookcount = Convert.ToInt32(row.Cells[3].Value);
                            int ShopValue = Convert.ToInt32(row.Cells[4].Value);
                            if (ShopBookcount + newAddBookCount > stock)
                            {
                                UIMessageBox.Show("库存不足！");
                            }
                            else
                            {
                                row.Cells[3].Value = ShopBookcount + newAddBookCount;
                                row.Cells[4].Value = ShopValue + total;
                                GoldTotal += total;
                                labTotal.Text = "￥" + GoldTotal.ToString();
                                Reset();
                            }
                            return;
                        }
                    }
                }
                //书不存在于购物车中,则新建一行进行添加
                DataGridViewRow dr = new DataGridViewRow();
                dr.CreateCells(ShopDGV);
                dr.Cells[0].Value = n++;
                dr.Cells[1].Value = txtBookName.Text;
                dr.Cells[2].Value = txtBookPrice.Text;
                dr.Cells[3].Value = txtBookCount.Text;
                dr.Cells[4].Value = total;
                ShopDGV.Rows.Add(dr);
                GoldTotal += total;
                labTotal.Text = "￥" + GoldTotal.ToString();
                Reset();
            }
        }



        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (ShopDGV.Rows.Count > 1)//默认有一行
            {
                //检查是否选中的行
                if (ShopDGV.SelectedRows.Count > 0)
                {
                    int rowIndex = ShopDGV.SelectedRows[0].Index;
                    if (ShopDGV.Rows[rowIndex].Cells[4].Value != null)//内容不为空
                    {
                        GoldTotal -= Convert.ToInt32(ShopDGV.Rows[rowIndex].Cells[4].Value.ToString());
                        labTotal.Text = "￥" + GoldTotal.ToString();
                        ShopDGV.Rows.RemoveAt(rowIndex);
                    }
                    else
                    {
                        UIMessageBox.Show("空行，没有可移除的项目！");
                    }
                }
                else
                {
                    // 如果没有选中的行，弹出提示框
                    UIMessageBox.Show("请在订单中选中要移除的项目！");
                }
            }
        }

        //结算后更新BookTb1
        public void UpdateBook()
        {
            if (ShopDGV.Rows.Count > 1)
            {
                foreach (DataGridViewRow row in ShopDGV.Rows)
                {
                    if (row != null && row.Cells[3].Value != null)
                    {
                        string PayBookname = row.Cells[1].Value.ToString();
                        int PayBookCount = Convert.ToInt32(row.Cells[3].Value);
                        string sql = String.Format("update BookTb1 set BQty=BQty - {0} where BTitle='{1}'", PayBookCount, PayBookname);
                        DBHelper.Update(sql);
                    }
                }
            }
        }

        //结算后更新BillTb1
        public void UpdateBill()
        {
            if (ShopDGV.Rows.Count > 1)
            {
                bool flag=true;
                foreach (DataGridViewRow row in ShopDGV.Rows)
                {
                    if (row != null && row.Cells[0].Value != null)
                    {
                        string UName = Login.UserName;
                        prodid = Convert.ToInt32(row.Cells[0].Value);
                        prodname = (string)row.Cells[1].Value;
                        prodprice = Convert.ToInt32(row.Cells[2].Value);
                        prodqty = Convert.ToInt32(row.Cells[3].Value);
                        tottal = Convert.ToInt32(row.Cells[4].Value);
                        string sql = String.Format("insert into BillTb1 values('{0}','{1}',{2},{3},{4})", UName, prodname, prodprice, prodqty, tottal);
                        if(!DBHelper.Update(sql))
                        {
                            flag = false;
                            break;
                        }
                    }
                }
                if (flag)
                {
                    UIMessageBox.Show("订单信息保存成功！");
                }
            }
            
        }
        private void btnPay_Click(object sender, EventArgs e)
        {
            if (ShopDGV.Rows[0].Cells[0].Value == null)
            {
                UIMessageBox.Show("购物车还是空的！");
            }
            else
            {
                //更新书籍表
                UpdateBook();

                //打印订单
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
                //订单存入订单表
                UpdateBill();
                //清空购物车
                ShopDGV.Rows.Clear();
                ShopDGV.Refresh();
                //总金额置0
                labTotal.Text = "￥ 0";
                GoldTotal = 0;
                //刷新表格
                LoadBookGrid();
                Reset();
            }
        }

        int prodid, prodqty, prodprice, tottal, pos = 60;
        string prodname;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // 使用e.Graphics在打印页面上绘制文本和图形
            e.Graphics.DrawString("码农书店", new Font("幼圆", 12, FontStyle.Bold), Brushes.Red, new Point(80));
            e.Graphics.DrawString("编号 产品 价格 数量 总计", new Font("幼圆", 10, FontStyle.Bold), Brushes.Red, new Point(26, 40));

            foreach (DataGridViewRow row in this.ShopDGV.Rows)
            {
                // 从DataGridView的单元格中获取数据
                prodid = Convert.ToInt32(row.Cells[0].Value);
                prodname = (string)row.Cells[1].Value;
                prodprice = Convert.ToInt32(row.Cells[2].Value);
                prodqty = Convert.ToInt32(row.Cells[3].Value);
                tottal = Convert.ToInt32(row.Cells[4].Value);
                // 在打印页面上绘制产品信息
                e.Graphics.DrawString(prodid.ToString(), new Font("幼圆", 8, FontStyle.Bold), Brushes.Blue, new Point(26, pos));
                e.Graphics.DrawString(prodname, new Font("幼圆", 8, FontStyle.Bold), Brushes.Blue, new Point(45, pos));
                e.Graphics.DrawString(prodprice.ToString(), new Font("幼圆", 8, FontStyle.Bold), Brushes.Blue, new Point(120, pos));
                e.Graphics.DrawString(prodqty.ToString(), new Font("幼圆", 8, FontStyle.Bold), Brushes.Blue, new Point(170, pos));
                e.Graphics.DrawString(tottal.ToString(), new Font("幼圆", 8, FontStyle.Bold), Brushes.Blue, new Point(235, pos));
                // 更新pos的位置，为下一行内容做准备
                pos = pos + 20;
            }
            // 绘制订单总额
            e.Graphics.DrawString("订单总额：" + GoldTotal, new Font("幼圆", 12, FontStyle.Bold), Brushes.Crimson, new Point(60, pos + 50));
            // 绘制分隔线或装饰性文本
            e.Graphics.DrawString("********** 码农书店 ***********", new Font("幼圆", 10, FontStyle.Bold), Brushes.Crimson, new Point(40, pos + 85));
        }

        private void ReturnArrow_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)//跳转到历史订单
        {
            UOrderHistory obj = new UOrderHistory();
            obj.Show();
            this.Hide();
        }
    }
}
