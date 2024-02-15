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
    public partial class formRecipe : Form     //레시피 등록
    {
        public formRecipe()
        {
            InitializeComponent();
        }

        private void formSystem3_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
