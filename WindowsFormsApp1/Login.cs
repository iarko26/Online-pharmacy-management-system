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
    public partial class Login : Form
    {
       
        public Login()
        {
            InitializeComponent();
        }
       
        private void gunaButton2_Click(object sender, EventArgs e)
        {
            
           SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Visual Studio 2019\Online Pharmecy\WindowsFormsApp1\Userlogin.mdf;Integrated Security=True");

            con.Open();


            if (Usertext.Text == "" || Passtext.Text == "")
            {
                MessageBox.Show("Please Enter the Username and Password");
            }

            if (Usertype.Text == "Supervisor")
            {
                try
                {
                    Usertext.Text = "Supervisor";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT * FROM logintable WHERE Username = '" + Usertext.Text + "'  AND Password = '" + Passtext.Text + "' ";
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                       
                        this.Hide();
                        string Username = Usertext.Text;
                        Home_page hp = new Home_page();
                        hp.Show();

                    }
                    else
                    {
                        MessageBox.Show("Login Failed! PLEASE ENTER THE CORRECT USERNAME AND PASSWORD");
                    }
                }

                finally
                {
                    if (con != null)
                    {
                        con.Close();
                    }
                }


            }




            else if (Usertype.Text == "Customer")
            {


                try
                {
                   // Usertext.Text = "Customer";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT * FROM logintable WHERE Username = '" + Usertext.Text + "'  AND Password = '" + Passtext.Text + "' ";
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read() == true)
                    {
                       
                        this.Hide();
                      //  string Username = Usertext.Text;
                        Customer cs = new Customer();
                        cs.Show();
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Login Failed! PLEASE ENTER THE CORRECT USERNAME AND PASSWORD");
                    }

                }



                finally
                {
                    if (con != null)
                    {
                        con.Close();
                    }
                }


            }


            else if (Usertype.Text == "Seller")
            {

                try {

                   // Usertext.Text = "Seller";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT * FROM logintable WHERE Username = '" + Usertext.Text + "'  AND Password = '" + Passtext.Text + "' ";
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                      
                        this.Hide();
                       // string Username = Usertext.Text;
                        Seller s = new Seller();
                        s.Show();
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Login Failed! PLEASE ENTER THE CORRECT USERNAME AND PASSWORD");
                    }

                }


                finally
                {
                    if (con != null)
                    {
                        con.Close();
                    }
                }

            }
           


        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

     
        private void Forgotlabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }


     
        private void showCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (showCheckBox1.Checked)
            {
                Passtext.PasswordChar = '\0' ;
            }

            else
            {
                Passtext.PasswordChar = '*';
            }
        }

        private void RegLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Registration R = new Registration();
            R.Show();
        }

        private void Passtext_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
