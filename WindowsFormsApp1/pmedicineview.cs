using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApp1
{
    public partial class pmedicineview : Medview
    {
        public pmedicineview()
        {
            InitializeComponent();
        }

        public void Getdata()
        {
            string qry = "select pID,pName,pPrice,CategoryID, c.catName from pmedicines p inner join category c on c.catID = p.CategoryID where pName like '%" + SearchTextBox1.Text + "' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);
            lb.Items.Add(dgvPrice);
            lb.Items.Add(dgvcatID);
            lb.Items.Add(dgvcat);

            Mainclass.Loaddata(qry, gunaCatDataGridView1, lb);
        }

        private void gunaImageAddButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void gunaCatDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pmedicineview_Load(object sender, EventArgs e)
        {
            Getdata();
        }

        public override void gunaImageAddButton1_Click(object sender, EventArgs e)
        {
            Mainclass.BlurBackground(new pmedicineAdd());
            Getdata();
        }

        public override void SearchTextBox1_TextChanged(object sender, EventArgs e)
        {
            Getdata();
        }

        private void gunaCatDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gunaCatDataGridView1.CurrentCell.OwningColumn.Name == "datagEdit")
            {
                pmedicineAdd pad = new pmedicineAdd();
                pad.id = Convert.ToInt32(gunaCatDataGridView1.CurrentRow.Cells["dgvid"].Value);
                pad.cID = Convert.ToInt32(gunaCatDataGridView1.CurrentRow.Cells["dgvcatID"].Value);
                Mainclass.BlurBackground(pad);
                Getdata();

            }
            if (gunaCatDataGridView1.CurrentCell.OwningColumn.Name == "datagDel")
            {
                    int id = Convert.ToInt32(gunaCatDataGridView1.CurrentRow.Cells["dgvid"].Value);
                    string qry = "Delete from pmedicines where pID =" + id + "";
                    Hashtable ht = new Hashtable();
                    Mainclass.SQL(qry, ht);

                    MessageBox.Show("Deleted");
                    Getdata();

            }
        }
    }
}
