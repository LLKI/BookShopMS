using Sunny.UI;
using System.Data;
using System.Data.SqlClient;
namespace BookShop
{
    public partial class Books : UIForm
    {
        public Books()
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
                uiDataGridView1.DataSource = ds.Tables[0];
                uiDataGridView1.Refresh();
            }
            else
            {
                UIMessageBox.Show("查询失败！");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBookName.Text == "" || txtAuthorName.Text == "" || txtBookCount.Text == "" || txtBookPrice.Text == "" || ComboBookKind.SelectedIndex == -1)
            {
                UIMessageBox.Show("消息缺失！");
            }
            else
            {
                string sql = "insert into BookTb1 values('" + txtBookName.Text + "','" + txtAuthorName.Text + "','" + ComboBookKind.SelectedItem.ToString() + "','" + txtBookCount.Text + "','" + txtBookPrice.Text + "')";
                if (DBHelper.Update(sql))
                {
                    LoadBookGrid();
                    Reset();
                    UIMessageBox.Show("书籍信息保存成功！");

                }
                else
                {
                    UIMessageBox.Show("书籍信息保存失败！");
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtBookName.Text == "" || txtAuthorName.Text == "" || txtBookCount.Text == "" || txtBookPrice.Text == "" || ComboBookKind.SelectedIndex == -1)
            {
                UIMessageBox.Show("消息缺失！");
            }
            else
            {
                //字符串记得去空格+单引号
                string sql = String.Format("update BookTb1 set BTitle='{0}',BAuthor='{1}',BCat='{2}',BQty={3},BPrice={4} where BId={5}",
                    txtBookName.Text.Trim(),
                    txtAuthorName.Text.Trim(),
                    ComboBookKind.SelectedItem.ToString().Trim(),
                    txtBookCount.Text.Trim(),
                    txtBookPrice.Text.Trim(),
                    BookID.ToString().Trim());
                if (DBHelper.Update(sql))
                {
                    LoadBookGrid();
                    Reset();
                    UIMessageBox.Show("书籍信息修改成功！");

                }
                else
                {
                    UIMessageBox.Show("书籍信息修改失败！");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LoadBookGrid();
            ComboBookKinds2.SelectedIndex = -1;
        }

        private void ComboBookKinds2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBookKinds2.SelectedIndex != -1)
            {
                string sql = "select * from BookTb1 where BCat='" + ComboBookKinds2.SelectedItem.ToString() + "'";
                SqlDataAdapter data = DBHelper.SelectForDataReader(sql);
                if (data != null)
                {
                    var ds = new DataSet();
                    data.Fill(ds);
                    uiDataGridView1.DataSource = ds.Tables[0];
                    uiDataGridView1.Refresh();
                }
                else
                {
                    UIMessageBox.Show("查询失败！");
                }
            }
        }

        public void Reset()
        {
            txtBookName.Text = "";
            txtAuthorName.Text = "";
            txtBookCount.Text = "";
            txtBookPrice.Text = "";
            ComboBookKind.SelectedIndex = -1;
            BookID = 0;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        int BookID = 0;
        private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBookName.Text = uiDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtAuthorName.Text = uiDataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            ComboBookKind.SelectedItem = uiDataGridView1.SelectedRows[0].Cells[3].Value.ToString().Trim();
            txtBookCount.Text = uiDataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtBookPrice.Text = uiDataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            BookID = Convert.ToInt32(uiDataGridView1.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (BookID == 0)
            {
                UIMessageBox.Show("请选中要删除的内容！");
            }
            else
            {
                string sql = String.Format("delete from BookTb1 where BId={0}", BookID);
                if (DBHelper.Update(sql))
                {
                    UIMessageBox.Show("删除成功！");
                    LoadBookGrid();
                    Reset();
                }
                else
                {
                    UIMessageBox.Show("删除失败！");
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)//书籍页面
        {
            Books obj = new Books();
            obj.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)//退出
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)//用户页面
        {
            Users obj = new Users();
            obj.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)//用户管理
        {
            DashBoard obj = new DashBoard();
            obj.Show();
            this.Hide();
        }

        private void labHistory_Click(object sender, EventArgs e)
        {
            MOrderHistory obj = new MOrderHistory();
            obj.Show();
            this.Hide();
        }
    }
}
