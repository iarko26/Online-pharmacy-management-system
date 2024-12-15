
namespace WindowsFormsApp1
{
    partial class pmedicineview
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pmedicineview));
            this.gunaCatDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.DatagS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datagEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.datagDel = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCatDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaImageAddButton1
            // 
            this.gunaImageAddButton1.Click += new System.EventHandler(this.gunaImageAddButton1_Click_1);
            // 
            // SearchTextBox1
            // 
            this.SearchTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.SearchTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.SearchTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.SearchTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Size = new System.Drawing.Size(96, 19);
            this.gunaLabel2.Text = "Medicine List";
            this.gunaLabel2.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            // 
            // gunaCatDataGridView1
            // 
            this.gunaCatDataGridView1.AllowUserToAddRows = false;
            this.gunaCatDataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.gunaCatDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.gunaCatDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaCatDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaCatDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.gunaCatDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaCatDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaCatDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaCatDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.gunaCatDataGridView1.ColumnHeadersHeight = 35;
            this.gunaCatDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DatagS,
            this.dgvid,
            this.dgvName,
            this.dgvPrice,
            this.dgvcatID,
            this.dgvcat,
            this.datagEdit,
            this.datagDel});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaCatDataGridView1.DefaultCellStyle = dataGridViewCellStyle15;
            this.gunaCatDataGridView1.EnableHeadersVisualStyles = false;
            this.gunaCatDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaCatDataGridView1.Location = new System.Drawing.Point(46, 164);
            this.gunaCatDataGridView1.Name = "gunaCatDataGridView1";
            this.gunaCatDataGridView1.ReadOnly = true;
            this.gunaCatDataGridView1.RowHeadersVisible = false;
            this.gunaCatDataGridView1.RowHeadersWidth = 51;
            this.gunaCatDataGridView1.RowTemplate.Height = 24;
            this.gunaCatDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaCatDataGridView1.Size = new System.Drawing.Size(793, 352);
            this.gunaCatDataGridView1.TabIndex = 8;
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
            this.gunaCatDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaCatDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaCatDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaCatDataGridView1.ThemeStyle.HeaderStyle.Height = 35;
            this.gunaCatDataGridView1.ThemeStyle.ReadOnly = true;
            this.gunaCatDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaCatDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaCatDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaCatDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaCatDataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.gunaCatDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaCatDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaCatDataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaCatDataGridView1_CellClick);
            this.gunaCatDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaCatDataGridView1_CellContentClick);
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
            this.dgvName.HeaderText = "Name";
            this.dgvName.MinimumWidth = 6;
            this.dgvName.Name = "dgvName";
            this.dgvName.ReadOnly = true;
            // 
            // dgvPrice
            // 
            this.dgvPrice.HeaderText = "Price";
            this.dgvPrice.Name = "dgvPrice";
            this.dgvPrice.ReadOnly = true;
            // 
            // dgvcatID
            // 
            this.dgvcatID.HeaderText = "cID";
            this.dgvcatID.Name = "dgvcatID";
            this.dgvcatID.ReadOnly = true;
            this.dgvcatID.Visible = false;
            // 
            // dgvcat
            // 
            this.dgvcat.HeaderText = "Category";
            this.dgvcat.Name = "dgvcat";
            this.dgvcat.ReadOnly = true;
            // 
            // datagEdit
            // 
            this.datagEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.datagEdit.FillWeight = 50F;
            this.datagEdit.HeaderText = "";
            this.datagEdit.Image = ((System.Drawing.Image)(resources.GetObject("datagEdit.Image")));
            this.datagEdit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.datagEdit.MinimumWidth = 50;
            this.datagEdit.Name = "datagEdit";
            this.datagEdit.ReadOnly = true;
            this.datagEdit.Width = 50;
            // 
            // datagDel
            // 
            this.datagDel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.datagDel.FillWeight = 50F;
            this.datagDel.HeaderText = "";
            this.datagDel.Image = ((System.Drawing.Image)(resources.GetObject("datagDel.Image")));
            this.datagDel.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.datagDel.MinimumWidth = 50;
            this.datagDel.Name = "datagDel";
            this.datagDel.ReadOnly = true;
            this.datagDel.Width = 50;
            // 
            // pmedicineview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 548);
            this.Controls.Add(this.gunaCatDataGridView1);
            this.Name = "pmedicineview";
            this.Text = "pmedicineview";
            this.Load += new System.EventHandler(this.pmedicineview_Load);
            this.Controls.SetChildIndex(this.gunaImageAddButton1, 0);
            this.Controls.SetChildIndex(this.SearchTextBox1, 0);
            this.Controls.SetChildIndex(this.gunaLabel1, 0);
            this.Controls.SetChildIndex(this.gunaLabel2, 0);
            this.Controls.SetChildIndex(this.gunaCatDataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gunaCatDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI.WinForms.GunaDataGridView gunaCatDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatagS;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcatID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcat;
        private System.Windows.Forms.DataGridViewImageColumn datagEdit;
        private System.Windows.Forms.DataGridViewImageColumn datagDel;
    }
}