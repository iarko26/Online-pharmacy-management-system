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
using System.IO;

namespace WindowsFormsApp1
{
    public partial class pmedicineAdd : MedAdd
    {
        public pmedicineAdd()
        {
            InitializeComponent();
        }
        public int id = 0;
        public int cID = 0;

        private void pmedicineAdd_Load(object sender, EventArgs e)
        {
            string qry = "Select catID 'id', catName 'name' from category ";
            Mainclass.CBFill(qry, mdCat);
            if (cID > 0)
            {
                mdCat.SelectedValue = cID;
            }
        }

        string filepath;
        Byte[] imageByteArray;
        private void Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images(.jpg, .png)|* .png; * .jpg";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                filepath = ofd.FileName;
                txtImage.Image = new Bitmap(filepath);
            }
        }

        public override void saveButton1_Click(object sender, EventArgs e)
        {
            string qry = "";

            if(id == 0)
            {
                qry = "Insert into pmedicines Values (@Name, @Price, @cat, @img)";
            }
            else
            {
                qry = "Update pmedicines set pName = @Name, pPrice = @Price, CategoryID = @cat, pImage = @img where pID = @id";
            }

            Image temp = new Bitmap(txtImage.Image);
            MemoryStream ms = new MemoryStream();
            temp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            imageByteArray = ms.ToArray();

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", mnamebox.Text);
            ht.Add("@Price", mprice.Text);
            ht.Add("@cat", Convert.ToInt32(mdCat.SelectedValue));
            ht.Add("@img", imageByteArray);

            if(Mainclass.SQL(qry, ht)>0)
            {
                guna2MessageDialog1.Show("Saved Succesfully");
                id = 0;
                mnamebox.Text = "";
                mprice.Text = "";
                mdCat.SelectedIndex = -1;
                mnamebox.Focus();
            }
        }
    }
}
