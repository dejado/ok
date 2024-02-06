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
    public partial class formInventory : Form
    {
        public formInventory()
        {
            InitializeComponent();
        }

        private void formInventory_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
