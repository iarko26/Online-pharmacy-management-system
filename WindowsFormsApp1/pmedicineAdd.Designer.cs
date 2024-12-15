
namespace WindowsFormsApp1
{
    partial class pmedicineAdd
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
            this.mnamebox = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.mprice = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.mdCat = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Browse = new Guna.UI2.WinForms.Guna2Button();
            this.TopPanel1.SuspendLayout();
            this.BottomPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImage)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel1
            // 
            this.TopPanel1.Size = new System.Drawing.Size(763, 131);
            // 
            // BottomPanel2
            // 
            this.BottomPanel2.Location = new System.Drawing.Point(0, 440);
            this.BottomPanel2.Size = new System.Drawing.Size(763, 78);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Size = new System.Drawing.Size(124, 20);
            this.gunaLabel1.Text = "Medicine Details";
            this.gunaLabel1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.icons8_pharmacy_96;
            this.gunaPictureBox1.Size = new System.Drawing.Size(96, 96);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            // 
            // saveButton1
            // 
            this.saveButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.saveButton1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            // 
            // CloseButton1
            // 
            this.CloseButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CloseButton1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            // 
            // mnamebox
            // 
            this.mnamebox.BaseColor = System.Drawing.Color.White;
            this.mnamebox.BorderColor = System.Drawing.Color.Silver;
            this.mnamebox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mnamebox.FocusedBaseColor = System.Drawing.Color.White;
            this.mnamebox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.mnamebox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.mnamebox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnamebox.Location = new System.Drawing.Point(44, 190);
            this.mnamebox.Name = "mnamebox";
            this.mnamebox.PasswordChar = '\0';
            this.mnamebox.SelectedText = "";
            this.mnamebox.Size = new System.Drawing.Size(232, 32);
            this.mnamebox.TabIndex = 2;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(41, 167);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(40, 15);
            this.gunaLabel2.TabIndex = 3;
            this.gunaLabel2.Text = "Name";
            // 
            // mprice
            // 
            this.mprice.BaseColor = System.Drawing.Color.White;
            this.mprice.BorderColor = System.Drawing.Color.Silver;
            this.mprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mprice.FocusedBaseColor = System.Drawing.Color.White;
            this.mprice.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.mprice.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.mprice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mprice.Location = new System.Drawing.Point(342, 190);
            this.mprice.Name = "mprice";
            this.mprice.PasswordChar = '\0';
            this.mprice.SelectedText = "";
            this.mprice.Size = new System.Drawing.Size(145, 32);
            this.mprice.TabIndex = 4;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(338, 167);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(35, 15);
            this.gunaLabel3.TabIndex = 5;
            this.gunaLabel3.Text = "Price";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(40, 265);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(57, 15);
            this.gunaLabel4.TabIndex = 7;
            this.gunaLabel4.Text = "Category";
            // 
            // mdCat
            // 
            this.mdCat.BackColor = System.Drawing.Color.Transparent;
            this.mdCat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.mdCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mdCat.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mdCat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mdCat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mdCat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.mdCat.ItemHeight = 30;
            this.mdCat.Location = new System.Drawing.Point(43, 295);
            this.mdCat.Name = "mdCat";
            this.mdCat.Size = new System.Drawing.Size(160, 36);
            this.mdCat.TabIndex = 9;
            // 
            // txtImage
            // 
            this.txtImage.Image = global::WindowsFormsApp1.Properties.Resources.icons8_medicine_96;
            this.txtImage.ImageRotate = 0F;
            this.txtImage.Location = new System.Drawing.Point(591, 190);
            this.txtImage.Name = "txtImage";
            this.txtImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.txtImage.Size = new System.Drawing.Size(119, 141);
            this.txtImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.txtImage.TabIndex = 10;
            this.txtImage.TabStop = false;
            // 
            // Browse
            // 
            this.Browse.AutoRoundedCorners = true;
            this.Browse.BorderRadius = 21;
            this.Browse.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Browse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Browse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Browse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Browse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Browse.ForeColor = System.Drawing.Color.White;
            this.Browse.Location = new System.Drawing.Point(574, 337);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(151, 45);
            this.Browse.TabIndex = 11;
            this.Browse.Text = "Browse";
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // pmedicineAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 518);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.txtImage);
            this.Controls.Add(this.mdCat);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.mprice);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.mnamebox);
            this.Controls.Add(this.gunaLabel2);
            this.Name = "pmedicineAdd";
            this.Text = "pmedicineAdd";
            this.Load += new System.EventHandler(this.pmedicineAdd_Load);
            this.Controls.SetChildIndex(this.TopPanel1, 0);
            this.Controls.SetChildIndex(this.BottomPanel2, 0);
            this.Controls.SetChildIndex(this.gunaLabel2, 0);
            this.Controls.SetChildIndex(this.mnamebox, 0);
            this.Controls.SetChildIndex(this.gunaLabel3, 0);
            this.Controls.SetChildIndex(this.mprice, 0);
            this.Controls.SetChildIndex(this.gunaLabel4, 0);
            this.Controls.SetChildIndex(this.mdCat, 0);
            this.Controls.SetChildIndex(this.txtImage, 0);
            this.Controls.SetChildIndex(this.Browse, 0);
            this.TopPanel1.ResumeLayout(false);
            this.TopPanel1.PerformLayout();
            this.BottomPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI.WinForms.GunaTextBox mnamebox;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        public Guna.UI.WinForms.GunaTextBox mprice;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI2.WinForms.Guna2ComboBox mdCat;
        private Guna.UI2.WinForms.Guna2CirclePictureBox txtImage;
        private Guna.UI2.WinForms.Guna2Button Browse;
    }
}