namespace BookShop
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            txtUserPwd = new Sunny.UI.UITextBox();
            txtUserName = new Sunny.UI.UITextBox();
            labMangerUser = new Label();
            btnLogin = new Sunny.UI.UIButton();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightBlue;
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(3, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(259, 364);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.book3;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(259, 364);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.AutoSize = true;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txtUserPwd);
            panel2.Controls.Add(txtUserName);
            panel2.Controls.Add(labMangerUser);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(268, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(342, 370);
            panel2.TabIndex = 1;
            // 
            // txtUserPwd
            // 
            txtUserPwd.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserPwd.Location = new Point(100, 207);
            txtUserPwd.Margin = new Padding(4, 5, 4, 5);
            txtUserPwd.MinimumSize = new Size(1, 16);
            txtUserPwd.Name = "txtUserPwd";
            txtUserPwd.Padding = new Padding(5);
            txtUserPwd.PasswordChar = '*';
            txtUserPwd.ShowText = false;
            txtUserPwd.Size = new Size(211, 29);
            txtUserPwd.TabIndex = 14;
            txtUserPwd.TextAlignment = ContentAlignment.MiddleLeft;
            txtUserPwd.Watermark = "";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(100, 168);
            txtUserName.Margin = new Padding(4, 5, 4, 5);
            txtUserName.MinimumSize = new Size(1, 16);
            txtUserName.Name = "txtUserName";
            txtUserName.Padding = new Padding(5);
            txtUserName.ShowText = false;
            txtUserName.Size = new Size(211, 29);
            txtUserName.TabIndex = 13;
            txtUserName.TextAlignment = ContentAlignment.MiddleLeft;
            txtUserName.Watermark = "";
            // 
            // labMangerUser
            // 
            labMangerUser.Anchor = AnchorStyles.Left;
            labMangerUser.AutoSize = true;
            labMangerUser.Font = new Font("微软雅黑", 10.5F, FontStyle.Underline, GraphicsUnit.Point);
            labMangerUser.Location = new Point(145, 302);
            labMangerUser.Name = "labMangerUser";
            labMangerUser.Size = new Size(51, 20);
            labMangerUser.TabIndex = 12;
            labMangerUser.Text = "管理员";
            labMangerUser.Click += labMangerUser_Click;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(100, 254);
            btnLogin.MinimumSize = new Size(1, 1);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(148, 35);
            btnLogin.TabIndex = 11;
            btnLogin.Text = "登录";
            btnLogin.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Click += btnLogin_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(29, 207);
            label3.Name = "label3";
            label3.Size = new Size(47, 22);
            label3.TabIndex = 8;
            label3.Text = "密码:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(29, 168);
            label2.Name = "label2";
            label2.Size = new Size(47, 22);
            label2.TabIndex = 7;
            label2.Text = "账号:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("微软雅黑", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(119, 23);
            label1.Name = "label1";
            label1.Size = new Size(92, 27);
            label1.TabIndex = 6;
            label1.Text = "码农书店";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.book2;
            pictureBox1.Location = new Point(100, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(148, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(610, 405);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Login";
            Text = "Login";
            TitleFont = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ZoomScaleRect = new Rectangle(15, 15, 505, 322);
            ZoomScaleSize = new Size(2, 0);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label labMangerUser;
        private Sunny.UI.UIButton btnLogin;
        private PictureBox pictureBox2;
        private Sunny.UI.UITextBox txtUserName;
        private Sunny.UI.UITextBox txtUserPwd;
    }
}