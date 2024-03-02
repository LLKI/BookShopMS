using Sunny.UI;
using System.Data;
using System.Data.SqlClient;
namespace BookShop
{
    public partial class MOrderHistory : UIForm
    {

        public MOrderHistory()
        {
            InitializeComponent();
            LoadHistoryGrid();
        }

        private void LoadHistoryGrid()
        {
            string sql = "select * from BillTb1";
            SqlDataAdapter data = DBHelper.SelectForDataReader(sql);
            if (data != null)
            {
                var ds = new DataSet();
                data.Fill(ds);
                HistoryDGV.DataSource = ds.Tables[0];
                HistoryDGV.Refresh();
            }
            else
            {
                UIMessageBox.Show("查询失败！");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LoadHistoryGrid();
            HistoryDGV.Refresh();
            txtSearch.Text = "";
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

        private void labHistory_Click(object sender, EventArgs e)//历史订单
        {
            MOrderHistory obj = new MOrderHistory();
            obj.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = String.Format("select * from BillTb1 where BillId={0}", Convert.ToInt32(txtSearch.Text));
            SqlDataAdapter data = DBHelper.SelectForDataReader(sql);
            if (data != null)
            {
                var ds = new DataSet();
                data.Fill(ds);
                HistoryDGV.DataSource = ds.Tables[0];
                HistoryDGV.Refresh();
            }
            else
            {
                UIMessageBox.Show("查询失败！");
            }
        }
    }
}
