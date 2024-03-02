namespace BookShop
{
    partial class MOrderHistory
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panel2 = new Panel();
            btnSearch = new Sunny.UI.UIButton();
            HistoryDGV = new Sunny.UI.UIDataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            btnUpdate = new Sunny.UI.UIButton();
            label1 = new Label();
            panel1 = new Panel();
            panel4 = new Panel();
            labHistory = new Label();
            pictureBox7 = new PictureBox();
            DashBoardPanel = new Panel();
            label11 = new Label();
            pictureBox5 = new PictureBox();
            UsersPanel = new Panel();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            bookPanel = new Panel();
            label8 = new Label();
            pictureBox4 = new PictureBox();
            ExitPanel = new Panel();
            label12 = new Label();
            pictureBox6 = new PictureBox();
            panel3 = new Panel();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            txtSearch = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HistoryDGV).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            DashBoardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            UsersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            bookPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ExitPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.LightBlue;
            panel2.Controls.Add(txtSearch);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(HistoryDGV);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(218, 36);
            panel2.Name = "panel2";
            panel2.Size = new Size(793, 713);
            panel2.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(257, 87);
            btnSearch.MinimumSize = new Size(1, 1);
            btnSearch.Name = "btnSearch";
            btnSearch.Radius = 1;
            btnSearch.Size = new Size(116, 35);
            btnSearch.TabIndex = 33;
            btnSearch.Text = "搜索";
            btnSearch.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Click += btnSearch_Click;
            // 
            // HistoryDGV
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 243, 255);
            HistoryDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            HistoryDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            HistoryDGV.BackgroundColor = Color.LightBlue;
            HistoryDGV.BorderStyle = BorderStyle.None;
            HistoryDGV.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            HistoryDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            HistoryDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            HistoryDGV.ColumnHeadersHeight = 32;
            HistoryDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            HistoryDGV.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            HistoryDGV.DefaultCellStyle = dataGridViewCellStyle3;
            HistoryDGV.EnableHeadersVisualStyles = false;
            HistoryDGV.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            HistoryDGV.GridColor = Color.FromArgb(80, 160, 255);
            HistoryDGV.Location = new Point(3, 137);
            HistoryDGV.Name = "HistoryDGV";
            HistoryDGV.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            HistoryDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            HistoryDGV.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            HistoryDGV.RowsDefaultCellStyle = dataGridViewCellStyle5;
            HistoryDGV.RowTemplate.Height = 25;
            HistoryDGV.SelectedIndex = -1;
            HistoryDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            HistoryDGV.Size = new Size(787, 548);
            HistoryDGV.StripeOddColor = Color.FromArgb(235, 243, 255);
            HistoryDGV.TabIndex = 30;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "BillId";
            Column1.HeaderText = "订单";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "UName";
            Column2.HeaderText = "用户名";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "BTitle";
            Column3.HeaderText = "产品";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "BPrice";
            Column4.HeaderText = "单价";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "BCount";
            Column5.HeaderText = "数量";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "AMount";
            Column6.HeaderText = "总额";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(483, 87);
            btnUpdate.MinimumSize = new Size(1, 1);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Radius = 1;
            btnUpdate.Size = new Size(116, 35);
            btnUpdate.TabIndex = 26;
            btnUpdate.Text = "更新";
            btnUpdate.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("微软雅黑", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(322, 11);
            label1.Name = "label1";
            label1.Size = new Size(133, 39);
            label1.TabIndex = 6;
            label1.Text = "订单列表";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(DashBoardPanel);
            panel1.Controls.Add(UsersPanel);
            panel1.Controls.Add(bookPanel);
            panel1.Location = new Point(0, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(218, 713);
            panel1.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(80, 160, 255);
            panel4.Controls.Add(labHistory);
            panel4.Controls.Add(pictureBox7);
            panel4.Location = new Point(2, 408);
            panel4.Name = "panel4";
            panel4.Size = new Size(215, 61);
            panel4.TabIndex = 13;
            // 
            // labHistory
            // 
            labHistory.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labHistory.Font = new Font("微软雅黑", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            labHistory.Location = new Point(67, 9);
            labHistory.Name = "labHistory";
            labHistory.Size = new Size(146, 44);
            labHistory.TabIndex = 11;
            labHistory.Text = "历史订单";
            labHistory.TextAlign = ContentAlignment.MiddleCenter;
            labHistory.Click += labHistory_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.历史订单;
            pictureBox7.Location = new Point(9, 8);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(57, 44);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 10;
            pictureBox7.TabStop = false;
            // 
            // DashBoardPanel
            // 
            DashBoardPanel.BackColor = Color.Transparent;
            DashBoardPanel.Controls.Add(label11);
            DashBoardPanel.Controls.Add(pictureBox5);
            DashBoardPanel.Location = new Point(0, 308);
            DashBoardPanel.Name = "DashBoardPanel";
            DashBoardPanel.Size = new Size(218, 61);
            DashBoardPanel.TabIndex = 11;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label11.Font = new Font("微软雅黑", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(67, 8);
            label11.Name = "label11";
            label11.Size = new Size(151, 44);
            label11.TabIndex = 11;
            label11.Text = "账户管理";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            label11.Click += label11_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Users;
            pictureBox5.Location = new Point(9, 8);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(57, 44);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            // 
            // UsersPanel
            // 
            UsersPanel.BackColor = Color.Transparent;
            UsersPanel.Controls.Add(label4);
            UsersPanel.Controls.Add(pictureBox3);
            UsersPanel.Location = new Point(0, 209);
            UsersPanel.Name = "UsersPanel";
            UsersPanel.Size = new Size(218, 61);
            UsersPanel.TabIndex = 10;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.Font = new Font("微软雅黑", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(67, 8);
            label4.Name = "label4";
            label4.Size = new Size(151, 44);
            label4.TabIndex = 11;
            label4.Text = "用户";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.user;
            pictureBox3.Location = new Point(9, 8);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(57, 44);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // bookPanel
            // 
            bookPanel.BackColor = Color.White;
            bookPanel.Controls.Add(label8);
            bookPanel.Controls.Add(pictureBox4);
            bookPanel.Location = new Point(-1, 113);
            bookPanel.Name = "bookPanel";
            bookPanel.Size = new Size(218, 61);
            bookPanel.TabIndex = 9;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label8.Font = new Font("微软雅黑", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(72, 8);
            label8.Name = "label8";
            label8.Size = new Size(136, 44);
            label8.TabIndex = 11;
            label8.Text = "书籍";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            label8.Click += label8_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.bookshelf;
            pictureBox4.Location = new Point(9, 8);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(57, 44);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // ExitPanel
            // 
            ExitPanel.BackColor = Color.White;
            ExitPanel.Controls.Add(label12);
            ExitPanel.Controls.Add(pictureBox6);
            ExitPanel.Location = new Point(2, 547);
            ExitPanel.Name = "ExitPanel";
            ExitPanel.Size = new Size(215, 61);
            ExitPanel.TabIndex = 12;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label12.Font = new Font("微软雅黑", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(67, 9);
            label12.Name = "label12";
            label12.Size = new Size(141, 44);
            label12.TabIndex = 11;
            label12.Text = "退出";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            label12.Click += label12_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.Exit;
            pictureBox6.Location = new Point(9, 8);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(57, 44);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 10;
            pictureBox6.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(0, 37);
            panel3.Name = "panel3";
            panel3.Size = new Size(218, 61);
            panel3.TabIndex = 13;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.Font = new Font("微软雅黑", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(67, 9);
            label3.Name = "label3";
            label3.Size = new Size(152, 44);
            label3.TabIndex = 11;
            label3.Text = "码农书店";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.home;
            pictureBox2.Location = new Point(9, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(57, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(21, 87);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "请输入订单号进行查询";
            txtSearch.Size = new Size(217, 35);
            txtSearch.TabIndex = 35;
            // 
            // MOrderHistory
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1011, 751);
            Controls.Add(panel3);
            Controls.Add(ExitPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "MOrderHistory";
            Text = "";
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)HistoryDGV).EndInit();
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            DashBoardPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            UsersPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            bookPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ExitPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private Sunny.UI.UIButton btnUpdate;
        private Sunny.UI.UIDataGridView HistoryDGV;
        private Panel DashBoardPanel;
        private Label label11;
        private PictureBox pictureBox5;
        private Panel UsersPanel;
        private Label label4;
        private PictureBox pictureBox3;
        private Panel bookPanel;
        private Label label8;
        private PictureBox pictureBox4;
        private Panel ExitPanel;
        private Label label12;
        private PictureBox pictureBox6;
        private Panel panel3;
        private Label label3;
        private PictureBox pictureBox2;
        private Panel panel4;
        private Label labHistory;
        private PictureBox pictureBox7;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Sunny.UI.UIButton btnSearch;
        private TextBox txtSearch;
    }
}