using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Home_page : Form
    {
        public Home_page()
        {
            InitializeComponent();
        }

        static Home_page _obj;
        public static Home_page Instance
        {
            get { if (_obj == null) { _obj = new Home_page(); } return _obj; }
        }


        public  void Addcontrols(Form f)
        {
            gunacenterPanel1.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            gunacenterPanel1.Controls.Add(f);
            f.Show();
        }
        private void gunaPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaPanel4_Paint(object sender, PaintEventArgs e)
        {

        }



        private void gunaControlBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaControlBox2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void gunaControlBox3_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Home_page_Load(object sender, EventArgs e)
        {
            _obj = this;
        }

        private void MainwinButton7_Click(object sender, EventArgs e)
        {
            Form frm = new frmMain();
            Addcontrols(frm);
        }

        private void catButton10_Click(object sender, EventArgs e)
        {
            Form frm1 = new Medcategoryview();
            Addcontrols(frm1);
        }

        private void MedButton9_Click(object sender, EventArgs e)
        {
            Addcontrols(new pmedicineview());
        }
    }
}
