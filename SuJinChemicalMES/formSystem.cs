using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuJinChemicalMES
{
    public partial class formSystem : Form
    {
        //formAddproduct addproduct;

        public formSystem()
        {
            InitializeComponent();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            /*
            if (addproduct == null)
            {
                addproduct = new formAddproduct();
                addproduct.FormClosed += Addproduct_FormClosed;
                addproduct.MdiParent = this;
                addproduct.Dock = DockStyle.Fill;
                addproduct.Show();
            }
            else
            {
                addproduct.Activate();
            }
            */
            formAddproduct formAddproduct = new formAddproduct();
            formAddproduct.Show();
        }

        private void Addproduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            //addproduct = null;
        }
    }
}
