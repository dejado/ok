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
    public partial class formWork : Form
    {
        public formWork()
        {
            InitializeComponent();

            pictureBox1.Image = Properties.Resources.tamk01; // 이미지는 Resources 폴더에 있어야 함
            // 이미지 박스 배경색 설정 (이 부분은 선택적이며, 투명 이미지의 배경색을 변경할 때 사용)
            pictureBox1.BackColor = Color.Transparent;

            pictureBox1.BackgroundImage = Properties.Resources.tamk01;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;  // 이미지를 PictureBox에 맞게 조절
            pictureBox1.BackColor = Color.Transparent;  // PictureBox의 배경을 투명하게 설정
        }

        private void formWork_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
