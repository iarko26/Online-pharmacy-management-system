
namespace WindowsFormsApp1
{
    partial class MedAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedAdd));
            this.TopPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.BottomPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.CloseButton1 = new Guna.UI.WinForms.GunaButton();
            this.saveButton1 = new Guna.UI.WinForms.GunaButton();
            this.guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.TopPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.BottomPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel1
            // 
            this.TopPanel1.BackColor = System.Drawing.Color.SlateBlue;
            this.TopPanel1.Controls.Add(this.gunaLabel1);
            this.TopPanel1.Controls.Add(this.gunaPictureBox1);
            this.TopPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel1.Location = new System.Drawing.Point(0, 0);
            this.TopPanel1.Name = "TopPanel1";
            this.TopPanel1.Size = new System.Drawing.Size(706, 131);
            this.TopPanel1.TabIndex = 0;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(137, 62);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(59, 20);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Header";
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Location = new System.Drawing.Point(12, 12);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(119, 109);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            // 
            // BottomPanel2
            // 
            this.BottomPanel2.BackColor = System.Drawing.Color.SteelBlue;
            this.BottomPanel2.Controls.Add(this.CloseButton1);
            this.BottomPanel2.Controls.Add(this.saveButton1);
            this.BottomPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel2.Location = new System.Drawing.Point(0, 379);
            this.BottomPanel2.Name = "BottomPanel2";
            this.BottomPanel2.Size = new System.Drawing.Size(706, 78);
            this.BottomPanel2.TabIndex = 1;
            // 
            // CloseButton1
            // 
            this.CloseButton1.AnimationHoverSpeed = 0.07F;
            this.CloseButton1.AnimationSpeed = 0.03F;
            this.CloseButton1.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton1.BaseColor = System.Drawing.Color.Transparent;
            this.CloseButton1.BorderColor = System.Drawing.Color.Black;
            this.CloseButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CloseButton1.FocusedColor = System.Drawing.Color.Empty;
            this.CloseButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton1.ForeColor = System.Drawing.SystemColors.Window;
            this.CloseButton1.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton1.Image")));
            this.CloseButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.CloseButton1.Location = new System.Drawing.Point(179, 24);
            this.CloseButton1.Name = "CloseButton1";
            this.CloseButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.CloseButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.CloseButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.CloseButton1.OnHoverImage = null;
            this.CloseButton1.OnPressedColor = System.Drawing.Color.Black;
            this.CloseButton1.Size = new System.Drawing.Size(140, 42);
            this.CloseButton1.TabIndex = 1;
            this.CloseButton1.Text = "Close";
            this.CloseButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CloseButton1.Click += new System.EventHandler(this.CloseButton1_Click);
            // 
            // saveButton1
            // 
            this.saveButton1.AnimationHoverSpeed = 0.07F;
            this.saveButton1.AnimationSpeed = 0.03F;
            this.saveButton1.BackColor = System.Drawing.Color.Transparent;
            this.saveButton1.BaseColor = System.Drawing.Color.Transparent;
            this.saveButton1.BorderColor = System.Drawing.Color.Black;
            this.saveButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.saveButton1.FocusedColor = System.Drawing.Color.Empty;
            this.saveButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton1.ForeColor = System.Drawing.Color.White;
            this.saveButton1.Image = ((System.Drawing.Image)(resources.GetObject("saveButton1.Image")));
            this.saveButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.saveButton1.Location = new System.Drawing.Point(22, 24);
            this.saveButton1.Name = "saveButton1";
            this.saveButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.saveButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.saveButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.saveButton1.OnHoverImage = null;
            this.saveButton1.OnPressedColor = System.Drawing.Color.Black;
            this.saveButton1.Size = new System.Drawing.Size(133, 42);
            this.saveButton1.TabIndex = 0;
            this.saveButton1.Text = "Save";
            this.saveButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.saveButton1.Click += new System.EventHandler(this.saveButton1_Click);
            // 
            // guna2MessageDialog1
            // 
            this.guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.guna2MessageDialog1.Caption = "OP";
            this.guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
            this.guna2MessageDialog1.Parent = this;
            this.guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.guna2MessageDialog1.Text = null;
            // 
            // MedAdd
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(706, 457);
            this.Controls.Add(this.BottomPanel2);
            this.Controls.Add(this.TopPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MedAdd";
            this.Text = "MedAdd";
            this.TopPanel1.ResumeLayout(false);
            this.TopPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.BottomPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI.WinForms.GunaPanel TopPanel1;
        public Guna.UI.WinForms.GunaPanel BottomPanel2;
        public Guna.UI.WinForms.GunaLabel gunaLabel1;
        public Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        public Guna.UI.WinForms.GunaButton saveButton1;
        public Guna.UI.WinForms.GunaButton CloseButton1;
        public Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
    }
}