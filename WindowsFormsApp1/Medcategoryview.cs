using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System;

namespace WindowsFormsApp1
{
    public partial class Medcategoryview : Medview
    {
        public Medcategoryview()
        {
            InitializeComponent();
        }
        public void Getdata()
        {
            string qry = "SELECT *From category where catName like '%" + SearchTextBox1.Text + " %' ";
            ListBox lb = new ListBox();
            lb.Items.Add(DatagId);
            lb.Items.Add(Datagname);
            Mainclass.Loaddata(qry, gunaCatDataGridView1, lb);



        }
        private void Medcategoryview_Load(object sender, EventArgs e)
        {
            Getdata();
        }

        public override void gunaImageAddButton1_Click(object sender, EventArgs e)
        {
            //MedcategoryAdd med = new MedcategoryAdd();
            //med.Show();
            Mainclass.BlurBackground(new MedcategoryAdd());
            Getdata();
        }

        public override void SearchTextBox1_TextChanged(object sender, EventArgs e)
        {
            Getdata();
        }

        private void gunaImageAddButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void gunaCatDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gunaCatDataGridView1.CurrentCell.OwningColumn.Name == "datagEdit")
            {
                MedcategoryAdd mad = new MedcategoryAdd();
                mad.id = Convert.ToInt32(gunaCatDataGridView1.CurrentRow.Cells["DatagId"].Value);
                mad.nameTextBox1.Text = Convert.ToString(gunaCatDataGridView1.CurrentRow.Cells["Datagname"].Value);
                Mainclass.BlurBackground(mad);
                Getdata();

            }
            if (gunaCatDataGridView1.CurrentCell.OwningColumn.Name == "datagDel")
            {
                int id = Convert.ToInt32(gunaCatDataGridView1.CurrentRow.Cells["DatagId"].Value);
                string qry = "Delete from category where catID =" + id + "";
                Hashtable ht = new Hashtable();
                Mainclass.SQL(qry, ht);
                MessageBox.Show("Deleted");
                Getdata();

            }
        }
    }
}
