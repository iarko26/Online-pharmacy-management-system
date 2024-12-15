
namespace WindowsFormsApp1
{
    partial class Medview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medview));
            this.gunaImageAddButton1 = new Guna.UI.WinForms.GunaImageButton();
            this.SearchTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.SuspendLayout();
            // 
            // gunaImageAddButton1
            // 
            this.gunaImageAddButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageAddButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaImageAddButton1.Image")));
            this.gunaImageAddButton1.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaImageAddButton1.Location = new System.Drawing.Point(46, 39);
            this.gunaImageAddButton1.Name = "gunaImageAddButton1";
            this.gunaImageAddButton1.OnHoverImage = null;
            this.gunaImageAddButton1.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageAddButton1.Size = new System.Drawing.Size(108, 85);
            this.gunaImageAddButton1.TabIndex = 0;
            this.gunaImageAddButton1.Click += new System.EventHandler(this.gunaImageAddButton1_Click);
            // 
            // SearchTextBox1
            // 
            this.SearchTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTextBox1.BaseColor = System.Drawing.Color.White;
            this.SearchTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.SearchTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.SearchTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SearchTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.SearchTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchTextBox1.Location = new System.Drawing.Point(571, 81);
            this.SearchTextBox1.Name = "SearchTextBox1";
            this.SearchTextBox1.PasswordChar = '\0';
            this.SearchTextBox1.SelectedText = "";
            this.SearchTextBox1.Size = new System.Drawing.Size(280, 43);
            this.SearchTextBox1.TabIndex = 1;
            this.SearchTextBox1.TextChanged += new System.EventHandler(this.SearchTextBox1_TextChanged);
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
            this.gunaLabel1.Location = new System.Drawing.Point(576, 55);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(54, 19);
            this.gunaLabel1.TabIndex = 3;
            this.gunaLabel1.Text = "Search";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(54, 27);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(91, 19);
            this.gunaLabel2.TabIndex = 4;
            this.gunaLabel2.Text = "Header Text";
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator1.Location = new System.Drawing.Point(58, 130);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(793, 10);
            this.gunaSeparator1.TabIndex = 5;
            // 
            // guna2MessageDialog1
            // 
            this.guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.guna2MessageDialog1.Caption = "OPM";
            this.guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
            this.guna2MessageDialog1.Parent = this;
            this.guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.guna2MessageDialog1.Text = null;
            // 
            // Medview
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(871, 548);
            this.Controls.Add(this.gunaSeparator1);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.SearchTextBox1);
            this.Controls.Add(this.gunaImageAddButton1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Medview";
            this.Text = "Medview";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI.WinForms.GunaImageButton gunaImageAddButton1;
        public Guna.UI.WinForms.GunaTextBox SearchTextBox1;
        public Guna.UI.WinForms.GunaLabel gunaLabel1;
        public Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        public Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
    }
}