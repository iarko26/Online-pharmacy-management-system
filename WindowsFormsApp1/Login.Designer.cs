
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.Usertype = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.Passtext = new Guna.UI.WinForms.GunaTextBox();
            this.Usertext = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.showCheckBox1 = new Guna.UI.WinForms.GunaCheckBox();
            this.Forgotlabel = new Guna.UI.WinForms.GunaLinkLabel();
            this.Exitbutton = new Guna.UI.WinForms.GunaButton();
            this.Loginbutton = new Guna.UI.WinForms.GunaButton();
            this.RegLinkLabel1 = new Guna.UI.WinForms.GunaLinkLabel();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.SlateBlue;
            this.gunaPanel1.Controls.Add(this.gunaLabel3);
            this.gunaPanel1.Controls.Add(this.gunaPictureBox1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(400, 136);
            this.gunaPanel1.TabIndex = 0;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.White;
            this.gunaLabel3.Location = new System.Drawing.Point(138, 102);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(108, 25);
            this.gunaLabel3.TabIndex = 1;
            this.gunaLabel3.Text = "User Login";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(143, 3);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(96, 96);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            // 
            // Usertype
            // 
            this.Usertype.BackColor = System.Drawing.Color.Transparent;
            this.Usertype.BaseColor = System.Drawing.Color.White;
            this.Usertype.BorderColor = System.Drawing.Color.Silver;
            this.Usertype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Usertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Usertype.FocusedColor = System.Drawing.Color.Empty;
            this.Usertype.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Usertype.ForeColor = System.Drawing.Color.Black;
            this.Usertype.FormattingEnabled = true;
            this.Usertype.Items.AddRange(new object[] {
            "Supervisor",
            "Seller",
            "Customer"});
            this.Usertype.Location = new System.Drawing.Point(55, 342);
            this.Usertype.Name = "Usertype";
            this.Usertype.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Usertype.OnHoverItemForeColor = System.Drawing.Color.White;
            this.Usertype.Size = new System.Drawing.Size(275, 31);
            this.Usertype.TabIndex = 7;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(192)))));
            this.gunaLabel4.Location = new System.Drawing.Point(51, 316);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(88, 23);
            this.gunaLabel4.TabIndex = 8;
            this.gunaLabel4.Text = "User Type";
            this.gunaLabel4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(192)))));
            this.gunaLabel2.Location = new System.Drawing.Point(51, 236);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(85, 23);
            this.gunaLabel2.TabIndex = 4;
            this.gunaLabel2.Text = "Password";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Passtext
            // 
            this.Passtext.BaseColor = System.Drawing.Color.White;
            this.Passtext.BorderColor = System.Drawing.Color.Silver;
            this.Passtext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Passtext.FocusedBaseColor = System.Drawing.Color.White;
            this.Passtext.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Passtext.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.Passtext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Passtext.Location = new System.Drawing.Point(55, 262);
            this.Passtext.Name = "Passtext";
            this.Passtext.PasswordChar = '*';
            this.Passtext.SelectedText = "";
            this.Passtext.Size = new System.Drawing.Size(275, 40);
            this.Passtext.TabIndex = 2;
            this.Passtext.TextChanged += new System.EventHandler(this.Passtext_TextChanged);
            // 
            // Usertext
            // 
            this.Usertext.BaseColor = System.Drawing.Color.White;
            this.Usertext.BorderColor = System.Drawing.Color.Silver;
            this.Usertext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Usertext.FocusedBaseColor = System.Drawing.Color.White;
            this.Usertext.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Usertext.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.Usertext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Usertext.Location = new System.Drawing.Point(55, 186);
            this.Usertext.Name = "Usertext";
            this.Usertext.PasswordChar = '\0';
            this.Usertext.SelectedText = "";
            this.Usertext.Size = new System.Drawing.Size(275, 47);
            this.Usertext.TabIndex = 1;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(192)))));
            this.gunaLabel1.Location = new System.Drawing.Point(51, 160);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(89, 23);
            this.gunaLabel1.TabIndex = 3;
            this.gunaLabel1.Text = "Username";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // showCheckBox1
            // 
            this.showCheckBox1.BaseColor = System.Drawing.Color.White;
            this.showCheckBox1.CheckedOffColor = System.Drawing.Color.Gray;
            this.showCheckBox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.showCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showCheckBox1.FillColor = System.Drawing.Color.White;
            this.showCheckBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(162)))));
            this.showCheckBox1.Location = new System.Drawing.Point(262, 308);
            this.showCheckBox1.Name = "showCheckBox1";
            this.showCheckBox1.Size = new System.Drawing.Size(64, 20);
            this.showCheckBox1.TabIndex = 9;
            this.showCheckBox1.Text = "Show";
            this.showCheckBox1.CheckedChanged += new System.EventHandler(this.showCheckBox1_CheckedChanged);
            // 
            // Forgotlabel
            // 
            this.Forgotlabel.AutoSize = true;
            this.Forgotlabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Forgotlabel.LinkColor = System.Drawing.Color.RoyalBlue;
            this.Forgotlabel.Location = new System.Drawing.Point(195, 452);
            this.Forgotlabel.Name = "Forgotlabel";
            this.Forgotlabel.Size = new System.Drawing.Size(135, 23);
            this.Forgotlabel.TabIndex = 13;
            this.Forgotlabel.TabStop = true;
            this.Forgotlabel.Text = "Forgot Password";
            this.Forgotlabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Forgotlabel_LinkClicked);
            // 
            // Exitbutton
            // 
            this.Exitbutton.AnimationHoverSpeed = 0.07F;
            this.Exitbutton.AnimationSpeed = 0.03F;
            this.Exitbutton.BaseColor = System.Drawing.Color.SteelBlue;
            this.Exitbutton.BorderColor = System.Drawing.Color.Black;
            this.Exitbutton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Exitbutton.FocusedColor = System.Drawing.Color.Empty;
            this.Exitbutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbutton.ForeColor = System.Drawing.Color.White;
            this.Exitbutton.Image = ((System.Drawing.Image)(resources.GetObject("Exitbutton.Image")));
            this.Exitbutton.ImageSize = new System.Drawing.Size(20, 20);
            this.Exitbutton.Location = new System.Drawing.Point(203, 392);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Exitbutton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Exitbutton.OnHoverForeColor = System.Drawing.Color.White;
            this.Exitbutton.OnHoverImage = null;
            this.Exitbutton.OnPressedColor = System.Drawing.Color.Black;
            this.Exitbutton.Size = new System.Drawing.Size(127, 42);
            this.Exitbutton.TabIndex = 14;
            this.Exitbutton.Text = "EXIT";
            this.Exitbutton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Exitbutton.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // Loginbutton
            // 
            this.Loginbutton.AnimationHoverSpeed = 0.07F;
            this.Loginbutton.AnimationSpeed = 0.03F;
            this.Loginbutton.BaseColor = System.Drawing.Color.SteelBlue;
            this.Loginbutton.BorderColor = System.Drawing.Color.Black;
            this.Loginbutton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Loginbutton.FocusedColor = System.Drawing.Color.Empty;
            this.Loginbutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbutton.ForeColor = System.Drawing.Color.White;
            this.Loginbutton.Image = ((System.Drawing.Image)(resources.GetObject("Loginbutton.Image")));
            this.Loginbutton.ImageSize = new System.Drawing.Size(20, 20);
            this.Loginbutton.Location = new System.Drawing.Point(55, 392);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Loginbutton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Loginbutton.OnHoverForeColor = System.Drawing.Color.White;
            this.Loginbutton.OnHoverImage = null;
            this.Loginbutton.OnPressedColor = System.Drawing.Color.Black;
            this.Loginbutton.Size = new System.Drawing.Size(127, 42);
            this.Loginbutton.TabIndex = 15;
            this.Loginbutton.Text = "LOGIN";
            this.Loginbutton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Loginbutton.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // RegLinkLabel1
            // 
            this.RegLinkLabel1.AutoSize = true;
            this.RegLinkLabel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegLinkLabel1.LinkColor = System.Drawing.Color.RoyalBlue;
            this.RegLinkLabel1.Location = new System.Drawing.Point(54, 452);
            this.RegLinkLabel1.Name = "RegLinkLabel1";
            this.RegLinkLabel1.Size = new System.Drawing.Size(111, 23);
            this.RegLinkLabel1.TabIndex = 16;
            this.RegLinkLabel1.TabStop = true;
            this.RegLinkLabel1.Text = "Register Now";
            this.RegLinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegLinkLabel1_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(400, 501);
            this.Controls.Add(this.RegLinkLabel1);
            this.Controls.Add(this.Loginbutton);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.Forgotlabel);
            this.Controls.Add(this.showCheckBox1);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.Usertype);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.Passtext);
            this.Controls.Add(this.Usertext);
            this.Controls.Add(this.gunaPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Login";
            this.Text = "Login";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void gunaLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        public Guna.UI.WinForms.GunaComboBox Usertype;
        public Guna.UI.WinForms.GunaLabel gunaLabel4;
        public Guna.UI.WinForms.GunaLabel gunaLabel2;
        public Guna.UI.WinForms.GunaTextBox Passtext;
        public Guna.UI.WinForms.GunaTextBox Usertext;
        public Guna.UI.WinForms.GunaLabel gunaLabel1;
        public Guna.UI.WinForms.GunaCheckBox showCheckBox1;
        public Guna.UI.WinForms.GunaLinkLabel Forgotlabel;
        public Guna.UI.WinForms.GunaButton Exitbutton;
        public Guna.UI.WinForms.GunaButton Loginbutton;
        public Guna.UI.WinForms.GunaLinkLabel RegLinkLabel1;
    }
}