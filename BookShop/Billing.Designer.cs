namespace BookShop
{
    partial class Billing
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
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle25 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle26 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle27 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle28 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle29 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle30 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
            panel2 = new Panel();
            label3 = new Label();
            ReturnArrow = new PictureBox();
            BookDGV = new Sunny.UI.UIDataGridView();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            ShopDGV = new Sunny.UI.UIDataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            labTotal = new Label();
            label2 = new Label();
            txtBookCount = new Sunny.UI.UITextBox();
            txtBookName = new Sunny.UI.UITextBox();
            txtBookPrice = new Sunny.UI.UITextBox();
            label10 = new Label();
            label9 = new Label();
            label5 = new Label();
            btnAdd = new Sunny.UI.UIButton();
            btnReset = new Sunny.UI.UIButton();
            btnRemove = new Sunny.UI.UIButton();
            btnPay = new Sunny.UI.UIButton();
            label1 = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ReturnArrow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BookDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ShopDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.LightBlue;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(ReturnArrow);
            panel2.Controls.Add(BookDGV);
            panel2.Controls.Add(ShopDGV);
            panel2.Controls.Add(labTotal);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtBookCount);
            panel2.Controls.Add(txtBookName);
            panel2.Controls.Add(txtBookPrice);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(btnReset);
            panel2.Controls.Add(btnRemove);
            panel2.Controls.Add(btnPay);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(1, 36);
            panel2.Name = "panel2";
            panel2.Size = new Size(1007, 713);
            panel2.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("微软雅黑", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(693, 489);
            label3.Name = "label3";
            label3.Size = new Size(162, 39);
            label3.TabIndex = 32;
            label3.Text = "订单金额：";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ReturnArrow
            // 
            ReturnArrow.BackColor = Color.LightBlue;
            ReturnArrow.Image = Properties.Resources.白色箭头;
            ReturnArrow.Location = new Point(0, 1);
            ReturnArrow.Name = "ReturnArrow";
            ReturnArrow.Size = new Size(32, 31);
            ReturnArrow.SizeMode = PictureBoxSizeMode.Zoom;
            ReturnArrow.TabIndex = 10;
            ReturnArrow.TabStop = false;
            ReturnArrow.Click += ReturnArrow_Click;
            // 
            // BookDGV
            // 
            dataGridViewCellStyle21.BackColor = Color.FromArgb(235, 243, 255);
            BookDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            BookDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BookDGV.BackgroundColor = Color.LightBlue;
            BookDGV.BorderStyle = BorderStyle.None;
            BookDGV.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            BookDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle22.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle22.ForeColor = Color.White;
            dataGridViewCellStyle22.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = DataGridViewTriState.True;
            BookDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            BookDGV.ColumnHeadersHeight = 32;
            BookDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            BookDGV.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12 });
            dataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = SystemColors.Window;
            dataGridViewCellStyle23.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle23.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle23.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = DataGridViewTriState.False;
            BookDGV.DefaultCellStyle = dataGridViewCellStyle23;
            BookDGV.EnableHeadersVisualStyles = false;
            BookDGV.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BookDGV.GridColor = Color.FromArgb(80, 160, 255);
            BookDGV.Location = new Point(0, 403);
            BookDGV.Name = "BookDGV";
            BookDGV.ReadOnly = true;
            dataGridViewCellStyle24.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle24.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle24.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle24.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle24.SelectionForeColor = Color.White;
            dataGridViewCellStyle24.WrapMode = DataGridViewTriState.True;
            BookDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            BookDGV.RowHeadersVisible = false;
            dataGridViewCellStyle25.BackColor = Color.White;
            dataGridViewCellStyle25.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BookDGV.RowsDefaultCellStyle = dataGridViewCellStyle25;
            BookDGV.RowTemplate.Height = 25;
            BookDGV.SelectedIndex = -1;
            BookDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BookDGV.Size = new Size(613, 297);
            BookDGV.StripeOddColor = Color.FromArgb(235, 243, 255);
            BookDGV.TabIndex = 34;
            BookDGV.CellContentClick += BookDGV_CellContentClick;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "BId";
            dataGridViewTextBoxColumn7.HeaderText = "编号";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "BTitle";
            dataGridViewTextBoxColumn8.HeaderText = "书名";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.DataPropertyName = "BAuthor";
            dataGridViewTextBoxColumn9.HeaderText = "作者";
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.DataPropertyName = "BCat";
            dataGridViewTextBoxColumn10.HeaderText = "类型";
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.DataPropertyName = "BQty";
            dataGridViewTextBoxColumn11.HeaderText = "库存";
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.DataPropertyName = "BPrice";
            dataGridViewTextBoxColumn12.HeaderText = "单价";
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // ShopDGV
            // 
            dataGridViewCellStyle26.BackColor = Color.FromArgb(235, 243, 255);
            ShopDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle26;
            ShopDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ShopDGV.BackgroundColor = Color.LightBlue;
            ShopDGV.BorderStyle = BorderStyle.None;
            ShopDGV.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ShopDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle27.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle27.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle27.ForeColor = Color.White;
            dataGridViewCellStyle27.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = DataGridViewTriState.True;
            ShopDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            ShopDGV.ColumnHeadersHeight = 32;
            ShopDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            ShopDGV.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dataGridViewCellStyle28.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = SystemColors.Window;
            dataGridViewCellStyle28.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle28.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle28.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = DataGridViewTriState.False;
            ShopDGV.DefaultCellStyle = dataGridViewCellStyle28;
            ShopDGV.EnableHeadersVisualStyles = false;
            ShopDGV.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ShopDGV.GridColor = Color.FromArgb(80, 160, 255);
            ShopDGV.Location = new Point(395, 72);
            ShopDGV.Name = "ShopDGV";
            ShopDGV.ReadOnly = true;
            dataGridViewCellStyle29.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle29.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle29.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle29.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle29.SelectionForeColor = Color.White;
            dataGridViewCellStyle29.WrapMode = DataGridViewTriState.True;
            ShopDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
            ShopDGV.RowHeadersVisible = false;
            dataGridViewCellStyle30.BackColor = Color.White;
            dataGridViewCellStyle30.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ShopDGV.RowsDefaultCellStyle = dataGridViewCellStyle30;
            ShopDGV.RowTemplate.Height = 25;
            ShopDGV.SelectedIndex = -1;
            ShopDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ShopDGV.Size = new Size(613, 297);
            ShopDGV.StripeOddColor = Color.FromArgb(235, 243, 255);
            ShopDGV.TabIndex = 32;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "BId";
            dataGridViewTextBoxColumn1.HeaderText = "订单号";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "BTitle";
            dataGridViewTextBoxColumn2.HeaderText = "书名";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "单价";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "数量";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "金额";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // labTotal
            // 
            labTotal.Anchor = AnchorStyles.Left;
            labTotal.AutoSize = true;
            labTotal.Font = new Font("微软雅黑", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            labTotal.Location = new Point(851, 489);
            labTotal.Name = "labTotal";
            labTotal.Size = new Size(73, 39);
            labTotal.TabIndex = 31;
            labTotal.Text = "￥ 0";
            labTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.Font = new Font("微软雅黑", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(142, 354);
            label2.Name = "label2";
            label2.Size = new Size(306, 27);
            label2.TabIndex = 29;
            label2.Text = "书籍列表";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBookCount
            // 
            txtBookCount.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBookCount.Location = new Point(299, 198);
            txtBookCount.Margin = new Padding(4, 5, 4, 5);
            txtBookCount.MinimumSize = new Size(1, 16);
            txtBookCount.Name = "txtBookCount";
            txtBookCount.Padding = new Padding(5);
            txtBookCount.ShowText = false;
            txtBookCount.Size = new Size(81, 29);
            txtBookCount.TabIndex = 25;
            txtBookCount.TextAlignment = ContentAlignment.MiddleLeft;
            txtBookCount.Watermark = "";
            // 
            // txtBookName
            // 
            txtBookName.Enabled = false;
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
            // txtBookPrice
            // 
            txtBookPrice.Enabled = false;
            txtBookPrice.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBookPrice.Location = new Point(199, 198);
            txtBookPrice.Margin = new Padding(4, 5, 4, 5);
            txtBookPrice.MinimumSize = new Size(1, 16);
            txtBookPrice.Name = "txtBookPrice";
            txtBookPrice.Padding = new Padding(5);
            txtBookPrice.ShowText = false;
            txtBookPrice.Size = new Size(81, 29);
            txtBookPrice.TabIndex = 23;
            txtBookPrice.TextAlignment = ContentAlignment.MiddleLeft;
            txtBookPrice.Watermark = "";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(199, 172);
            label10.Name = "label10";
            label10.Size = new Size(42, 22);
            label10.TabIndex = 22;
            label10.Text = "价格";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(299, 171);
            label9.Name = "label9";
            label9.Size = new Size(42, 22);
            label9.TabIndex = 21;
            label9.Text = "数量";
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
            // btnAdd
            // 
            btnAdd.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(31, 261);
            btnAdd.MinimumSize = new Size(1, 1);
            btnAdd.Name = "btnAdd";
            btnAdd.Radius = 1;
            btnAdd.Size = new Size(172, 35);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "加入购物车";
            btnAdd.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Click += btnAdd_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.Location = new Point(244, 261);
            btnReset.MinimumSize = new Size(1, 1);
            btnReset.Name = "btnReset";
            btnReset.Radius = 1;
            btnReset.Size = new Size(116, 35);
            btnReset.TabIndex = 13;
            btnReset.Text = "重置";
            btnReset.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnReset.Click += btnReset_Click;
            // 
            // btnRemove
            // 
            btnRemove.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRemove.Location = new Point(680, 403);
            btnRemove.MinimumSize = new Size(1, 1);
            btnRemove.Name = "btnRemove";
            btnRemove.Radius = 1;
            btnRemove.Size = new Size(116, 35);
            btnRemove.TabIndex = 11;
            btnRemove.Text = "移除";
            btnRemove.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemove.Click += btnRemove_Click;
            // 
            // btnPay
            // 
            btnPay.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPay.Location = new Point(854, 403);
            btnPay.MinimumSize = new Size(1, 1);
            btnPay.Name = "btnPay";
            btnPay.Radius = 1;
            btnPay.Size = new Size(116, 35);
            btnPay.TabIndex = 16;
            btnPay.Text = "结算";
            btnPay.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnPay.Click += btnPay_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("微软雅黑", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(442, 12);
            label1.Name = "label1";
            label1.Size = new Size(104, 39);
            label1.TabIndex = 6;
            label1.Text = "购物车";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightBlue;
            pictureBox1.Image = Properties.Resources.历史订单;
            pictureBox1.Location = new Point(976, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Billing
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1011, 751);
            Controls.Add(panel2);
            MaximizeBox = false;
            Name = "Billing";
            Text = "";
            TitleFont = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ReturnArrow).EndInit();
            ((System.ComponentModel.ISupportInitialize)BookDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)ShopDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Sunny.UI.UIButton btnAdd;
        private Sunny.UI.UIButton btnReset;
        private Sunny.UI.UIButton btnRemove;
        private Sunny.UI.UIButton btnPay;
        private Label label10;
        private Label label9;
        private Label label5;
        private Sunny.UI.UITextBox txtBookCount;
        private Sunny.UI.UITextBox txtBookName;
        private Sunny.UI.UITextBox txtBookPrice;
        private Label label2;
        private PictureBox ReturnArrow;
        private Label labTotal;
        private Sunny.UI.UIDataGridView ShopDGV;
        private Sunny.UI.UIDataGridView BookDGV;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private Label label3;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private PictureBox pictureBox1;
    }
}