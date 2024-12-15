
namespace WindowsFormsApp1
{
    partial class MedcategoryAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedcategoryAdd));
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.nameTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.TopPanel1.SuspendLayout();
            this.BottomPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel1
            // 
            this.TopPanel1.Size = new System.Drawing.Size(400, 131);
            this.TopPanel1.TabIndex = 3;
            // 
            // BottomPanel2
            // 
            this.BottomPanel2.Location = new System.Drawing.Point(0, 325);
            this.BottomPanel2.Size = new System.Drawing.Size(400, 78);
            this.BottomPanel2.TabIndex = 2;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Location = new System.Drawing.Point(82, 59);
            this.gunaLabel1.Size = new System.Drawing.Size(136, 25);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Add Category";
            this.gunaLabel1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(12, 34);
            this.gunaPictureBox1.Size = new System.Drawing.Size(64, 64);
            // 
            // saveButton1
            // 
            this.saveButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.saveButton1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            // 
            // CloseButton1
            // 
            this.CloseButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CloseButton1.TabIndex = 0;
            this.CloseButton1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(18, 146);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(51, 20);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Name";
            // 
            // nameTextBox1
            // 
            this.nameTextBox1.BaseColor = System.Drawing.Color.White;
            this.nameTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.nameTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.nameTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.nameTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.nameTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nameTextBox1.Location = new System.Drawing.Point(22, 169);
            this.nameTextBox1.Modified = true;
            this.nameTextBox1.Name = "nameTextBox1";
            this.nameTextBox1.PasswordChar = '\0';
            this.nameTextBox1.SelectedText = "";
            this.nameTextBox1.Size = new System.Drawing.Size(232, 32);
            this.nameTextBox1.TabIndex = 0;
            // 
            // MedcategoryAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 403);
            this.Controls.Add(this.nameTextBox1);
            this.Controls.Add(this.gunaLabel2);
            this.Name = "MedcategoryAdd";
            this.Text = "MedcategoryAdd";
            this.Controls.SetChildIndex(this.TopPanel1, 0);
            this.Controls.SetChildIndex(this.BottomPanel2, 0);
            this.Controls.SetChildIndex(this.gunaLabel2, 0);
            this.Controls.SetChildIndex(this.nameTextBox1, 0);
            this.TopPanel1.ResumeLayout(false);
            this.TopPanel1.PerformLayout();
            this.BottomPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        public Guna.UI.WinForms.GunaTextBox nameTextBox1;
    }
}