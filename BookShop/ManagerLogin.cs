using Sunny.UI;
namespace BookShop
{
    public partial class ManagerLogin : UIForm
    {
        public ManagerLogin()
        {
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)//普通用户登录
        {

            if (txtUserPwd.Text == "12345")
            {
                UIMessageBox.Show("登录成功！");
                //跳转到管理员界面
                Books obj = new Books();
                obj.Show();
                this.Hide();
            }
            else
            {
                UIMessageBox.Show("密码错误！");
            }
        }

        private void labMangerUser_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }
    }
}
