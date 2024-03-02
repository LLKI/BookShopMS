namespace BookShop
{
    partial class Books
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            panel2 = new Panel();
            ComboBookKind = new Sunny.UI.UIComboBox();
            uiDataGridView1 = new Sunny.UI.UIDataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            label2 = new Label();
            ComboBookKinds2 = new Sunny.UI.UIComboBox();
            btnUpdate = new Sunny.UI.UIButton();
            txtBookPrice = new Sunny.UI.UITextBox();
            txtAuthorName = new Sunny.UI.UITextBox();
            txtBookName = new Sunny.UI.UITextBox();
            txtBookCount = new Sunny.UI.UITextBox();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            btnSave = new Sunny.UI.UIButton();
            btnEdit = new Sunny.UI.UIButton();
            btnDel = new Sunny.UI.UIButton();
            btnReset = new Sunny.UI.UIButton();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
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
            panel4 = new Panel();
            labHistory = new Label();
            pictureBox7 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
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
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.LightBlue;
            panel2.Controls.Add(ComboBookKind);
            panel2.Controls.Add(uiDataGridView1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(ComboBookKinds2);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(txtBookPrice);
            panel2.Controls.Add(txtAuthorName);
            panel2.Controls.Add(txtBookName);
            panel2.Controls.Add(txtBookCount);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(btnEdit);
            panel2.Controls.Add(btnDel);
            panel2.Controls.Add(btnReset);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(218, 36);
            panel2.Name = "panel2";
            panel2.Size = new Size(793, 713);
            panel2.TabIndex = 3;
            // 
            // ComboBookKind
            // 
            ComboBookKind.DataSource = null;
            ComboBookKind.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            ComboBookKind.FillColor = Color.White;
            ComboBookKind.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ComboBookKind.ItemHoverColor = Color.FromArgb(155, 200, 255);
            ComboBookKind.Items.AddRange(new object[] { "科学技术", "文学艺术", "儿童读物", "人文历史", "经济管理", "生活美食" });
            ComboBookKind.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            ComboBookKind.Location = new Point(404, 198);
            ComboBookKind.Margin = new Padding(4, 5, 4, 5);
            ComboBookKind.MinimumSize = new Size(63, 0);
            ComboBookKind.Name = "ComboBookKind";
            ComboBookKind.Padding = new Padding(0, 0, 30, 2);
            ComboBookKind.Size = new Size(169, 29);
            ComboBookKind.TabIndex = 31;
            ComboBookKind.Text = "全部分类";
            ComboBookKind.TextAlignment = ContentAlignment.MiddleLeft;
            ComboBookKind.Watermark = "";
            // 
            // uiDataGridView1
            // 
            dataGridViewCellStyle6.BackColor = Color.FromArgb(235, 243, 255);
            uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            uiDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            uiDataGridView1.BackgroundColor = Color.LightBlue;
            uiDataGridView1.BorderStyle = BorderStyle.None;
            uiDataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            uiDataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle7.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            uiDataGridView1.ColumnHeadersHeight = 32;
            uiDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            uiDataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            uiDataGridView1.EnableHeadersVisualStyles = false;
            uiDataGridView1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiDataGridView1.GridColor = Color.FromArgb(80, 160, 255);
            uiDataGridView1.Location = new Point(3, 392);
            uiDataGridView1.Name = "uiDataGridView1";
            uiDataGridView1.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle9.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            uiDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            uiDataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle10;
            uiDataGridView1.RowTemplate.Height = 25;
            uiDataGridView1.SelectedIndex = -1;
            uiDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            uiDataGridView1.Size = new Size(787, 293);
            uiDataGridView1.StripeOddColor = Color.FromArgb(235, 243, 255);
            uiDataGridView1.TabIndex = 30;
            uiDataGridView1.CellContentClick += uiDataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "BId";
            Column1.HeaderText = "书籍编号";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "BTitle";
            Column2.HeaderText = "书籍名称";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "BAuthor";
            Column3.HeaderText = "作者";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "BCat";
            Column4.HeaderText = "书籍类型";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "BQty";
            Column5.HeaderText = "数量";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "BPrice";
            Column6.HeaderText = "价格";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.Font = new Font("微软雅黑", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(322, 321);
            label2.Name = "label2";
            label2.Size = new Size(92, 27);
            label2.TabIndex = 29;
            label2.Text = "书籍列表";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ComboBookKinds2
            // 
            ComboBookKinds2.AllowDrop = true;
            ComboBookKinds2.DataSource = null;
            ComboBookKinds2.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            ComboBookKinds2.FillColor = Color.White;
            ComboBookKinds2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ComboBookKinds2.ItemHoverColor = Color.FromArgb(155, 200, 255);
            ComboBookKinds2.Items.AddRange(new object[] { "科学技术", "文学艺术", "儿童读物", "人文历史", "经济管理", "生活美食" });
            ComboBookKinds2.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            ComboBookKinds2.Location = new Point(286, 353);
            ComboBookKinds2.Margin = new Padding(4, 5, 4, 5);
            ComboBookKinds2.MinimumSize = new Size(63, 0);
            ComboBookKinds2.Name = "ComboBookKinds2";
            ComboBookKinds2.Padding = new Padding(0, 0, 30, 2);
            ComboBookKinds2.Size = new Size(169, 29);
            ComboBookKinds2.TabIndex = 28;
            ComboBookKinds2.Text = "选定类目";
            ComboBookKinds2.TextAlignment = ContentAlignment.MiddleLeft;
            ComboBookKinds2.Watermark = "";
            ComboBookKinds2.SelectedIndexChanged += ComboBookKinds2_SelectedIndexChanged;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(489, 347);
            btnUpdate.MinimumSize = new Size(1, 1);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Radius = 1;
            btnUpdate.Size = new Size(116, 35);
            btnUpdate.TabIndex = 26;
            btnUpdate.Text = "更新";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtBookPrice
            // 
            txtBookPrice.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBookPrice.Location = new Point(693, 198);
            txtBookPrice.Margin = new Padding(4, 5, 4, 5);
            txtBookPrice.MinimumSize = new Size(1, 16);
            txtBookPrice.Name = "txtBookPrice";
            txtBookPrice.Padding = new Padding(5);
            txtBookPrice.ShowText = false;
            txtBookPrice.Size = new Size(81, 29);
            txtBookPrice.TabIndex = 25;
            txtBookPrice.TextAlignment = ContentAlignment.MiddleLeft;
            txtBookPrice.Watermark = "";
            // 
            // txtAuthorName
            // 
            txtAuthorName.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAuthorName.Location = new Point(207, 198);
            txtAuthorName.Margin = new Padding(4, 5, 4, 5);
            txtAuthorName.MinimumSize = new Size(1, 16);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Padding = new Padding(5);
            txtAuthorName.ShowText = false;
            txtAuthorName.Size = new Size(169, 29);
            txtAuthorName.TabIndex = 15;
            txtAuthorName.TextAlignment = ContentAlignment.MiddleLeft;
            txtAuthorName.Watermark = "";
            // 
            // txtBookName
            // 
            txtBookName.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBookName.Location = new Point(7, 198);
            txtBookName.Margin = new Padding(4, 5, 4, 5);
            txtBookName.MinimumSize = new Size(1, 16);
            txtBookName.Name = "txtBookName";
            txtBookName.Padding = new Padding(5);
            txtBookName.ShowText = false;
            txtBookName.Size = new Size(169, 29);
            txtBookName.TabIndex = 14;
            txtBookName.TextAlignment = ContentAlignment.MiddleLeft;
            txtBookName.Watermark = "";
            // 
            // txtBookCount
            // 
            txtBookCount.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBookCount.Location = new Point(593, 198);
            txtBookCount.Margin = new Padding(4, 5, 4, 5);
            txtBookCount.MinimumSize = new Size(1, 16);
            txtBookCount.Name = "txtBookCount";
            txtBookCount.Padding = new Padding(5);
            txtBookCount.ShowText = false;
            txtBookCount.Size = new Size(81, 29);
            txtBookCount.TabIndex = 23;
            txtBookCount.TextAlignment = ContentAlignment.MiddleLeft;
            txtBookCount.Watermark = "";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(593, 172);
            label10.Name = "label10";
            label10.Size = new Size(42, 22);
            label10.TabIndex = 22;
            label10.Text = "数量";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(693, 172);
            label9.Name = "label9";
            label9.Size = new Size(42, 22);
            label9.TabIndex = 21;
            label9.Text = "价格";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(404, 172);
            label7.Name = "label7";
            label7.Size = new Size(74, 22);
            label7.TabIndex = 19;
            label7.Text = "书籍类型";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(207, 172);
            label6.Name = "label6";
            label6.Size = new Size(42, 22);
            label6.TabIndex = 18;
            label6.Text = "作者";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(7, 172);
            label5.Name = "label5";
            label5.Size = new Size(74, 22);
            label5.TabIndex = 17;
            label5.Text = "书籍名称";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(70, 261);
            btnSave.MinimumSize = new Size(1, 1);
            btnSave.Name = "btnSave";
            btnSave.Radius = 1;
            btnSave.Size = new Size(116, 35);
            btnSave.TabIndex = 15;
            btnSave.Text = "保存";
            btnSave.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Click += btnSave_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.Location = new Point(244, 261);
            btnEdit.MinimumSize = new Size(1, 1);
            btnEdit.Name = "btnEdit";
            btnEdit.Radius = 1;
            btnEdit.Size = new Size(116, 35);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "编辑";
            btnEdit.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDel
            // 
            btnDel.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDel.Location = new Point(427, 261);
            btnDel.MinimumSize = new Size(1, 1);
            btnDel.Name = "btnDel";
            btnDel.Radius = 1;
            btnDel.Size = new Size(116, 35);
            btnDel.TabIndex = 11;
            btnDel.Text = "删除";
            btnDel.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDel.Click += btnDel_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.Location = new Point(603, 261);
            btnReset.MinimumSize = new Size(1, 1);
            btnReset.Name = "btnReset";
            btnReset.Radius = 1;
            btnReset.Size = new Size(116, 35);
            btnReset.TabIndex = 16;
            btnReset.Text = "重置";
            btnReset.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnReset.Click += btnReset_Click;
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
            label1.Text = "码农书店";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.book2;
            pictureBox1.Location = new Point(331, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
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
            bookPanel.BackColor = Color.FromArgb(80, 160, 255);
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
            ExitPanel.Location = new Point(2, 548);
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
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(labHistory);
            panel4.Controls.Add(pictureBox7);
            panel4.Location = new Point(2, 409);
            panel4.Name = "panel4";
            panel4.Size = new Size(215, 61);
            panel4.TabIndex = 14;
            // 
            // labHistory
            // 
            labHistory.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labHistory.Font = new Font("微软雅黑", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            labHistory.Location = new Point(67, 8);
            labHistory.Name = "labHistory";
            labHistory.Size = new Size(148, 44);
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
            // Books
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1011, 751);
            Controls.Add(panel3);
            Controls.Add(ExitPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Books";
            Text = "Books";
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
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
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Sunny.UI.UIButton btnSave;
        private Sunny.UI.UIButton btnEdit;
        private Sunny.UI.UIButton btnDel;
        private Sunny.UI.UIButton btnReset;
        private Label label10;
        private Label label9;
        private Label label7;
        private Label label6;
        private Label label5;
        private Sunny.UI.UITextBox txtBookPrice;
        private Sunny.UI.UITextBox txtAuthorName;
        private Sunny.UI.UITextBox txtBookName;
        private Sunny.UI.UITextBox txtBookCount;
        private Sunny.UI.UIButton btnUpdate;
        private Label label2;
        private Sunny.UI.UIComboBox ComboBookKinds2;
        private Sunny.UI.UIDataGridView uiDataGridView1;
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
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Sunny.UI.UIComboBox ComboBookKind;
        private Panel panel4;
        private Label labHistory;
        private PictureBox pictureBox7;
    }
}