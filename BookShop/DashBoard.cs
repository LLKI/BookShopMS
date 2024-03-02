using Sunny.UI;
namespace BookShop
{
    public partial class DashBoard : UIForm
    {
        public DashBoard()
        {
            Load += DashBoard_Load;
            InitializeComponent();
        }

        private void DashBoard_Load(object? sender, EventArgs e)
        {
            string sqlUser = "select count(*) from UserTb1";
            string sqlBill = "select sum(Amount) from BillTb1";
            string sqlBook = "select sum(BQty) from BookTb1";
            int UserCount = 0, AmountSum = 0, BookCount = 0;
            if (DBHelper.SelectForScalar(sqlUser) != DBNull.Value)
            {
                UserCount = (int)DBHelper.SelectForScalar(sqlUser);
            }

            if (DBHelper.SelectForScalar(sqlBill) != DBNull.Value)
            {
                AmountSum = (int)DBHelper.SelectForScalar(sqlBill);
            }

            if (DBHelper.SelectForScalar(sqlBook) != DBNull.Value)
            {
                BookCount = (int)DBHelper.SelectForScalar(sqlBook);
            }
            labUserCount.Text = UserCount.ToString() + " 人";
            labSaleCount.Text = AmountSum.ToString() + " ￥";
            labbookCount.Text = BookCount.ToString() + " 本";
        }

        private void label11_Click(object sender, EventArgs e)
        {
            DashBoard obj = new DashBoard();
            obj.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Users obj = new Users();
            obj.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Books obj = new Books();
            obj.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
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
