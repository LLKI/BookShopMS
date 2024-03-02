namespace BookShop
{
    partial class ManagerLogin
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
            panel2 = new Panel();
            txtUserPwd = new Sunny.UI.UITextBox();
            labMangerUser = new Label();
            btnLogin = new Sunny.UI.UIButton();
            label3 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Left;
            panel2.AutoSize = true;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txtUserPwd);
            panel2.Controls.Add(labMangerUser);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(1, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(336, 370);
            panel2.TabIndex = 1;
            // 
            // txtUserPwd
            // 
            txtUserPwd.Anchor = AnchorStyles.Left;
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
            // labMangerUser
            // 
            labMangerUser.Anchor = AnchorStyles.Left;
            labMangerUser.AutoSize = true;
            labMangerUser.Font = new Font("微软雅黑", 10.5F, FontStyle.Underline, GraphicsUnit.Point);
            labMangerUser.Location = new Point(145, 302);
            labMangerUser.Name = "labMangerUser";
            labMangerUser.Size = new Size(37, 20);
            labMangerUser.TabIndex = 12;
            labMangerUser.Text = "返回";
            labMangerUser.Click += labMangerUser_Click;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Left;
            btnLogin.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(100, 254);
            btnLogin.MinimumSize = new Size(1, 1);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(148, 35);
            btnLogin.TabIndex = 11;
            btnLogin.Text = "登录";
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
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
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
            pictureBox1.Anchor = AnchorStyles.Left;
            pictureBox1.Image = Properties.Resources.book2;
            pictureBox1.Location = new Point(100, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(148, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // ManagerLogin
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(340, 405);
            Controls.Add(panel2);
            MaximizeBox = false;
            Name = "ManagerLogin";
            Text = "ManagerLogin";
            TitleFont = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ZoomScaleRect = new Rectangle(15, 15, 505, 322);
            ZoomScaleSize = new Size(2, 0);
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