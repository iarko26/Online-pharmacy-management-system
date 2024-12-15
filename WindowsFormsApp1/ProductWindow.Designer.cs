
namespace WindowsFormsApp1
{
    partial class ProductWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductWindow));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.CategoryPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ProductPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaCatDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.DatagS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.SearchTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.totalprice = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.mdProduct1 = new WindowsFormsApp1.mdProduct();
            this.mdProduct2 = new WindowsFormsApp1.mdProduct();
            this.mdProduct3 = new WindowsFormsApp1.mdProduct();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            this.CategoryPanel.SuspendLayout();
            this.ProductPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCatDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(168)))));
            this.gunaPanel1.Controls.Add(this.gunaPictureBox2);
            this.gunaPanel1.Controls.Add(this.gunaPictureBox1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1087, 104);
            this.gunaPanel1.TabIndex = 0;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(168)))));
            this.gunaPanel2.Controls.Add(this.total);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaPanel2.Location = new System.Drawing.Point(0, 542);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(1087, 90);
            this.gunaPanel2.TabIndex = 1;
            // 
            // CategoryPanel
            // 
            this.CategoryPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CategoryPanel.Controls.Add(this.guna2Button1);
            this.CategoryPanel.Location = new System.Drawing.Point(12, 179);
            this.CategoryPanel.Name = "CategoryPanel";
            this.CategoryPanel.Size = new System.Drawing.Size(144, 357);
            this.CategoryPanel.TabIndex = 2;
            // 
            // ProductPanel
            // 
            this.ProductPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductPanel.AutoScroll = true;
            this.ProductPanel.Controls.Add(this.mdProduct1);
            this.ProductPanel.Controls.Add(this.mdProduct2);
            this.ProductPanel.Controls.Add(this.mdProduct3);
            this.ProductPanel.Location = new System.Drawing.Point(162, 179);
            this.ProductPanel.Name = "ProductPanel";
            this.ProductPanel.Size = new System.Drawing.Size(544, 357);
            this.ProductPanel.TabIndex = 3;
            this.ProductPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ProductPanel_Paint);
            // 
            // gunaCatDataGridView1
            // 
            this.gunaCatDataGridView1.AllowUserToAddRows = false;
            this.gunaCatDataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gunaCatDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gunaCatDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaCatDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaCatDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.gunaCatDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaCatDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaCatDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaCatDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gunaCatDataGridView1.ColumnHeadersHeight = 35;
            this.gunaCatDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DatagS,
            this.dgvid,
            this.dgvName,
            this.dgvQty,
            this.dgvPrice,
            this.dgvAmount});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaCatDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.gunaCatDataGridView1.EnableHeadersVisualStyles = false;
            this.gunaCatDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaCatDataGridView1.Location = new System.Drawing.Point(763, 163);
            this.gunaCatDataGridView1.Name = "gunaCatDataGridView1";
            this.gunaCatDataGridView1.ReadOnly = true;
            this.gunaCatDataGridView1.RowHeadersVisible = false;
            this.gunaCatDataGridView1.RowHeadersWidth = 51;
            this.gunaCatDataGridView1.RowTemplate.Height = 24;
            this.gunaCatDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaCatDataGridView1.Size = new System.Drawing.Size(312, 373);
            this.gunaCatDataGridView1.TabIndex = 9;
            this.gunaCatDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gunaCatDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaCatDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaCatDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaCatDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaCatDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaCatDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaCatDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaCatDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.SteelBlue;
            this.gunaCatDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaCatDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaCatDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaCatDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaCatDataGridView1.ThemeStyle.HeaderStyle.Height = 35;
            this.gunaCatDataGridView1.ThemeStyle.ReadOnly = true;
            this.gunaCatDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaCatDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaCatDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaCatDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaCatDataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.gunaCatDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaCatDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaCatDataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gunaCatDataGridView1_CellFormatting);
            // 
            // DatagS
            // 
            this.DatagS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DatagS.FillWeight = 70F;
            this.DatagS.HeaderText = "Sr#";
            this.DatagS.MinimumWidth = 70;
            this.DatagS.Name = "DatagS";
            this.DatagS.ReadOnly = true;
            this.DatagS.Width = 70;
            // 
            // dgvid
            // 
            this.dgvid.FillWeight = 70F;
            this.dgvid.HeaderText = "id";
            this.dgvid.MinimumWidth = 70;
            this.dgvid.Name = "dgvid";
            this.dgvid.ReadOnly = true;
            this.dgvid.Visible = false;
            // 
            // dgvName
            // 
            this.dgvName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvName.HeaderText = "Name";
            this.dgvName.Name = "dgvName";
            this.dgvName.ReadOnly = true;
            // 
            // dgvQty
            // 
            this.dgvQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvQty.FillWeight = 30F;
            this.dgvQty.HeaderText = "Qty";
            this.dgvQty.MinimumWidth = 30;
            this.dgvQty.Name = "dgvQty";
            this.dgvQty.ReadOnly = true;
            this.dgvQty.Width = 30;
            // 
            // dgvPrice
            // 
            this.dgvPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvPrice.FillWeight = 50F;
            this.dgvPrice.HeaderText = "Price";
            this.dgvPrice.MinimumWidth = 50;
            this.dgvPrice.Name = "dgvPrice";
            this.dgvPrice.ReadOnly = true;
            this.dgvPrice.Width = 50;
            // 
            // dgvAmount
            // 
            this.dgvAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvAmount.FillWeight = 60F;
            this.dgvAmount.HeaderText = "Amount";
            this.dgvAmount.MinimumWidth = 60;
            this.dgvAmount.Name = "dgvAmount";
            this.dgvAmount.ReadOnly = true;
            this.dgvAmount.Width = 60;
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.icons8_close_96;
            this.gunaPictureBox2.Location = new System.Drawing.Point(989, 12);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(73, 78);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox2.TabIndex = 1;
            this.gunaPictureBox2.TabStop = false;
            this.gunaPictureBox2.Click += new System.EventHandler(this.gunaPictureBox2_Click);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Location = new System.Drawing.Point(12, 12);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(73, 78);
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(3, 3);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(134, 45);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Text = "guna2Button1";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.gunaLabel1.Location = new System.Drawing.Point(167, 107);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(54, 19);
            this.gunaLabel1.TabIndex = 11;
            this.gunaLabel1.Text = "Search";
            // 
            // SearchTextBox1
            // 
            this.SearchTextBox1.BaseColor = System.Drawing.Color.White;
            this.SearchTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.SearchTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.SearchTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SearchTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.SearchTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchTextBox1.Location = new System.Drawing.Point(162, 133);
            this.SearchTextBox1.Name = "SearchTextBox1";
            this.SearchTextBox1.PasswordChar = '\0';
            this.SearchTextBox1.SelectedText = "";
            this.SearchTextBox1.Size = new System.Drawing.Size(280, 40);
            this.SearchTextBox1.TabIndex = 10;
            this.SearchTextBox1.TextChanged += new System.EventHandler(this.SearchTextBox1_TextChanged);
            // 
            // totalprice
            // 
            this.totalprice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totalprice.AutoSize = true;
            this.totalprice.BackColor = System.Drawing.Color.WhiteSmoke;
            this.totalprice.Location = new System.Drawing.Point(986, 567);
            this.totalprice.Name = "totalprice";
            this.totalprice.Size = new System.Drawing.Size(32, 17);
            this.totalprice.TabIndex = 0;
            this.totalprice.Text = "0.00";
            // 
            // total
            // 
            this.total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.total.AutoSize = true;
            this.total.BackColor = System.Drawing.Color.WhiteSmoke;
            this.total.Location = new System.Drawing.Point(894, 25);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(68, 17);
            this.total.TabIndex = 1;
            this.total.Text = "Total Price";
            // 
            // mdProduct1
            // 
            this.mdProduct1.id = 0;
            this.mdProduct1.Location = new System.Drawing.Point(3, 78);
            this.mdProduct1.Margin = new System.Windows.Forms.Padding(3, 78, 3, 78);
            this.mdProduct1.Name = "mdProduct1";
            this.mdProduct1.PCategory = null;
            this.mdProduct1.PImage = ((System.Drawing.Image)(resources.GetObject("mdProduct1.PImage")));
            this.mdProduct1.PName = "Product Name";
            this.mdProduct1.PPrice = null;
            this.mdProduct1.Size = new System.Drawing.Size(953, 3716);
            this.mdProduct1.TabIndex = 0;
            // 
            // mdProduct2
            // 
            this.mdProduct2.id = 0;
            this.mdProduct2.Location = new System.Drawing.Point(3, 3950);
            this.mdProduct2.Margin = new System.Windows.Forms.Padding(3, 78, 3, 78);
            this.mdProduct2.Name = "mdProduct2";
            this.mdProduct2.PCategory = null;
            this.mdProduct2.PImage = ((System.Drawing.Image)(resources.GetObject("mdProduct2.PImage")));
            this.mdProduct2.PName = "Product Name";
            this.mdProduct2.PPrice = null;
            this.mdProduct2.Size = new System.Drawing.Size(953, 3716);
            this.mdProduct2.TabIndex = 1;
            // 
            // mdProduct3
            // 
            this.mdProduct3.id = 0;
            this.mdProduct3.Location = new System.Drawing.Point(3, 7822);
            this.mdProduct3.Margin = new System.Windows.Forms.Padding(3, 78, 3, 78);
            this.mdProduct3.Name = "mdProduct3";
            this.mdProduct3.PCategory = null;
            this.mdProduct3.PImage = ((System.Drawing.Image)(resources.GetObject("mdProduct3.PImage")));
            this.mdProduct3.PName = "Product Name";
            this.mdProduct3.PPrice = null;
            this.mdProduct3.Size = new System.Drawing.Size(955, 3716);
            this.mdProduct3.TabIndex = 2;
            // 
            // ProductWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1087, 632);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.totalprice);
            this.Controls.Add(this.SearchTextBox1);
            this.Controls.Add(this.gunaCatDataGridView1);
            this.Controls.Add(this.ProductPanel);
            this.Controls.Add(this.CategoryPanel);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.gunaPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ProductWindow";
            this.Text = "ProductWindow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProductWindow_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel2.PerformLayout();
            this.CategoryPanel.ResumeLayout(false);
            this.ProductPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaCatDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private System.Windows.Forms.FlowLayoutPanel CategoryPanel;
        private System.Windows.Forms.FlowLayoutPanel ProductPanel;
        public Guna.UI.WinForms.GunaDataGridView gunaCatDataGridView1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatagS;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAmount;
        private mdProduct mdProduct1;
        private mdProduct mdProduct2;
        private mdProduct mdProduct3;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        public Guna.UI.WinForms.GunaLabel gunaLabel1;
        public Guna.UI.WinForms.GunaTextBox SearchTextBox1;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label totalprice;
    }
}