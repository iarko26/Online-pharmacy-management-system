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
using System.Collections;

namespace WindowsFormsApp1
{
    public partial class MedcategoryAdd : MedAdd
    {
        public MedcategoryAdd()
        {
            InitializeComponent();
        }
       
       
        public int id = 0;
        public override void saveButton1_Click(object sender, EventArgs e)
        {
            string qry = "";
            if (id == 0)
            {
                qry = "Insert into category Values(@Name)";
            }

            else
            {
                qry = "Update category Set catName=@Name where catID=@id";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", nameTextBox1.Text);
            if (Mainclass.SQL(qry, ht )> 0)
            {
                MessageBox.Show("Saved succesfully");
                id = 0;
                nameTextBox1.Text = "";
                nameTextBox1.Focus();
            }


        }
    }
}
