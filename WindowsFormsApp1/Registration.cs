using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }


    
        private void backloginLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }
         SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\all semester\7th Semester\OOP2\c# project\c# project\WindowsFormsApp1\Userlogin.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

       
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if(UserTextBox1.Text=="" && PassTextBox2.Text == "" && ConpassTextBox3.Text=="")
            {
                MessageBox.Show("Registration Failed!");
            }

                else if (PassTextBox2.Text== ConpassTextBox3.Text)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into logintable values('" + UserTextBox1.Text + "','" + PassTextBox2.Text + "','"+ gunaComboBox1.Text+"')";
                cmd.ExecuteNonQuery();
                
                UserTextBox1.Text = "";
                PassTextBox2.Text = "";
                ConpassTextBox3.Text = "";
                MessageBox.Show("Your Account Has Been Successfully Created");
               
                /*PassTextBox2.Focus();*/

            }


            else
            {
                MessageBox.Show("Passwords doesnot match,Please re-enter to register");

                PassTextBox2.Text = "";
                ConpassTextBox3.Text = "";
                PassTextBox2.Focus();

            
            
            }
        }

        private void UserTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void PassTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
