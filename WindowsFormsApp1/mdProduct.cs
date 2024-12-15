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
    public partial class mdProduct : UserControl
    {
        public mdProduct()
        {
            InitializeComponent();
        }
        public event EventHandler onSelect = null;
        public int id { get; set; }
        public string PPrice { get; set; }

        public string PCategory { get; set; }

        public string PName
        {
            get { return lbName.Text; }
            set { lbName.Text = value; }
        }

        public Image PImage
        {
            get { return lbImage.Image; }
            set { lbImage.Image = value; }
        }

        private void lbImage_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }
    }
}
