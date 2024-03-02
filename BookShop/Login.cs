using Sunny.UI;
namespace BookShop
{
    public partial class Login : UIForm
    {
        public Login()
        {
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            InitializeComponent();
        }

        public static string UserName = "";
        private void btnLogin_Click(object sender, EventArgs e)//普通用户登录
        {
            string sql = String.Format("select count(0) from UserTb1 where UName='{0}' and UPassword='{1}'", txtUserName.Text, txtUserPwd.Text);
            if ((int)DBHelper.SelectForScalar(sql) == 1)
            {
                UIMessageBox.Show("登录成功！");
                UserName = txtUserName.Text;
                //跳转到购物车界面
                Billing obj = new Billing();
                obj.Show();
                this.Hide();
            }
            else
            {
                UIMessageBox.Show("用户名或密码错误！");
            }
        }

        private void labMangerUser_Click(object sender, EventArgs e)
        {
            ManagerLogin obj = new ManagerLogin();
            obj.Show();
            this.Hide();
        }
    }
}
