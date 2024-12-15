using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
    class Mainclass
    {

        public static readonly string con_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Visual Studio 2019\Online Pharmecy\WindowsFormsApp1\Userlogin.mdf;Integrated Security=True";
        public static SqlConnection con = new SqlConnection(con_string);




        public static int SQL(string qry, Hashtable ht)
        {
            int res = 0;
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Visual Studio 2019\Online Pharmecy\WindowsFormsApp1\Userlogin.mdf;Integrated Security=True"))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(qry, con);
                    cmd.CommandType = CommandType.Text;

                    foreach (DictionaryEntry item in ht)
                    {
                        cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                    }

                    con.Open();
                    res = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            return res;
        }

        public static void Loaddata(string qry, DataGridView d, ListBox lb)
        {
            d.CellFormatting += new DataGridViewCellFormattingEventHandler(d_CellFormatting);

            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Visual Studio 2019\Online Pharmecy\WindowsFormsApp1\Userlogin.mdf;Integrated Security=True"))
                {
                    SqlCommand cmd = new SqlCommand(qry, con);
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    for (int i = 0; i < lb.Items.Count; i++)
                    {
                        string col1 = ((DataGridViewColumn)lb.Items[i]).Name;
                        d.Columns[col1].DataPropertyName = dt.Columns[i].ToString();
                    }

                    d.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private static void d_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Guna.UI.WinForms.GunaDataGridView d = (Guna.UI.WinForms.GunaDataGridView)sender;
            //Guna.UI2.WinForms.Guna2DataGridView d = (Guna.UI2.WinForms.Guna2DataGridView)sender;
            int count = 0;
            foreach(DataGridViewRow row in d.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        public static void BlurBackground(Form Model)
        {
            Form Background = new Form();
            using(Model)
            {
                Background.StartPosition = FormStartPosition.Manual;
                Background.FormBorderStyle = FormBorderStyle.None;
                Background.Opacity = 0.5d;
                Background.BackColor = Color.Black;
                Background.Size = Home_page.Instance.Size;
                Background.Location = Home_page.Instance.Location;
                Background.ShowInTaskbar = false;
                Background.Show();
                Model.Owner = Background;
                Model.ShowDialog(Background);
                Background.Dispose();
            }
        }

        public static void CBFill(string qry,ComboBox cb)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Visual Studio 2019\Online Pharmecy\WindowsFormsApp1\Userlogin.mdf;Integrated Security=True"))
                {
                    SqlCommand cmd = new SqlCommand(qry, con);
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cb.DisplayMember = "name";
                    cb.ValueMember = "id";
                    cb.DataSource = dt;
                    cb.SelectedIndex = -1;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


    }
}

 

