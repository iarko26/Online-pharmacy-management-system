
namespace WindowsFormsApp1
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.HeadLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.UserTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.PassTextBox2 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.ConpassTextBox3 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.backloginLinkLabel1 = new Guna.UI.WinForms.GunaLinkLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaComboBox1 = new Guna.UI.WinForms.GunaComboBox();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.SlateBlue;
            this.gunaPanel1.Controls.Add(this.HeadLabel1);
            this.gunaPanel1.Controls.Add(this.gunaCirclePictureBox1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(493, 162);
            this.gunaPanel1.TabIndex = 0;
            // 
            // HeadLabel1
            // 
            this.HeadLabel1.AutoSize = true;
            this.HeadLabel1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.HeadLabel1.Location = new System.Drawing.Point(164, 123);
            this.HeadLabel1.Name = "HeadLabel1";
            this.HeadLabel1.Size = new System.Drawing.Size(165, 25);
            this.HeadLabel1.TabIndex = 1;
            this.HeadLabel1.Text = "User Registration";
            this.HeadLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaCirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaCirclePictureBox1.Image")));
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(193, 12);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(96, 96);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.gunaCirclePictureBox1.TabIndex = 0;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(103, 182);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(89, 23);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Username";
            // 
            // UserTextBox1
            // 
            this.UserTextBox1.BaseColor = System.Drawing.Color.White;
            this.UserTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.UserTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.UserTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.UserTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.UserTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UserTextBox1.Location = new System.Drawing.Point(107, 208);
            this.UserTextBox1.Name = "UserTextBox1";
            this.UserTextBox1.PasswordChar = '\0';
            this.UserTextBox1.SelectedText = "";
            this.UserTextBox1.Size = new System.Drawing.Size(287, 32);
            this.UserTextBox1.TabIndex = 2;
            this.UserTextBox1.TextChanged += new System.EventHandler(this.UserTextBox1_TextChanged);
            // 
            // PassTextBox2
            // 
            this.PassTextBox2.BaseColor = System.Drawing.Color.White;
            this.PassTextBox2.BorderColor = System.Drawing.Color.Silver;
            this.PassTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PassTextBox2.FocusedBaseColor = System.Drawing.Color.White;
            this.PassTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.PassTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.PassTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PassTextBox2.Location = new System.Drawing.Point(107, 297);
            this.PassTextBox2.Name = "PassTextBox2";
            this.PassTextBox2.PasswordChar = '\0';
            this.PassTextBox2.SelectedText = "";
            this.PassTextBox2.Size = new System.Drawing.Size(287, 32);
            this.PassTextBox2.TabIndex = 3;
            this.PassTextBox2.TextChanged += new System.EventHandler(this.PassTextBox2_TextChanged);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(107, 271);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(85, 23);
            this.gunaLabel2.TabIndex = 4;
            this.gunaLabel2.Text = "Password";
            // 
            // ConpassTextBox3
            // 
            this.ConpassTextBox3.BaseColor = System.Drawing.Color.White;
            this.ConpassTextBox3.BorderColor = System.Drawing.Color.Silver;
            this.ConpassTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ConpassTextBox3.FocusedBaseColor = System.Drawing.Color.White;
            this.ConpassTextBox3.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ConpassTextBox3.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.ConpassTextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ConpassTextBox3.Location = new System.Drawing.Point(107, 377);
            this.ConpassTextBox3.Name = "ConpassTextBox3";
            this.ConpassTextBox3.PasswordChar = '\0';
            this.ConpassTextBox3.SelectedText = "";
            this.ConpassTextBox3.Size = new System.Drawing.Size(287, 32);
            this.ConpassTextBox3.TabIndex = 5;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(103, 351);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(156, 23);
            this.gunaLabel3.TabIndex = 6;
            this.gunaLabel3.Text = "Confirm Password";
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.SteelBlue;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(169, 507);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(160, 42);
            this.gunaButton1.TabIndex = 7;
            this.gunaButton1.Text = "Register";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.gunaLabel4.Location = new System.Drawing.Point(154, 567);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(191, 20);
            this.gunaLabel4.TabIndex = 8;
            this.gunaLabel4.Text = "Already Have an Account?";
            this.gunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backloginLinkLabel1
            // 
            this.backloginLinkLabel1.AutoSize = true;
            this.backloginLinkLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backloginLinkLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backloginLinkLabel1.LinkColor = System.Drawing.Color.MediumSlateBlue;
            this.backloginLinkLabel1.Location = new System.Drawing.Point(189, 601);
            this.backloginLinkLabel1.Name = "backloginLinkLabel1";
            this.backloginLinkLabel1.Size = new System.Drawing.Size(106, 20);
            this.backloginLinkLabel1.TabIndex = 9;
            this.backloginLinkLabel1.TabStop = true;
            this.backloginLinkLabel1.Text = "Back To Login";
            this.backloginLinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.backloginLinkLabel1_LinkClicked);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(103, 425);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(88, 23);
            this.gunaLabel5.TabIndex = 10;
            this.gunaLabel5.Text = "User Type";
            // 
            // gunaComboBox1
            // 
            this.gunaComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaComboBox1.BaseColor = System.Drawing.Color.White;
            this.gunaComboBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaComboBox1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaComboBox1.ForeColor = System.Drawing.Color.Black;
            this.gunaComboBox1.FormattingEnabled = true;
            this.gunaComboBox1.Items.AddRange(new object[] {
            "Customer",
            "Seller"});
            this.gunaComboBox1.Location = new System.Drawing.Point(107, 451);
            this.gunaComboBox1.Name = "gunaComboBox1";
            this.gunaComboBox1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaComboBox1.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaComboBox1.Size = new System.Drawing.Size(287, 31);
            this.gunaComboBox1.TabIndex = 11;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(493, 635);
            this.Controls.Add(this.gunaComboBox1);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.backloginLinkLabel1);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.ConpassTextBox3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.PassTextBox2);
            this.Controls.Add(this.UserTextBox1);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI.WinForms.GunaPanel gunaPanel1;
        public Guna.UI.WinForms.GunaLabel HeadLabel1;
        public Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        public Guna.UI.WinForms.GunaTextBox UserTextBox1;
        public Guna.UI.WinForms.GunaTextBox PassTextBox2;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        public Guna.UI.WinForms.GunaTextBox ConpassTextBox3;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        public Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        public Guna.UI.WinForms.GunaLinkLabel backloginLinkLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        public Guna.UI.WinForms.GunaComboBox gunaComboBox1;
    }
}