using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
            dataGridView1.RowHeadersVisible = false;
            dataGridView2.RowHeadersVisible = false;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            // DataGridView에서 선택한 행의 인덱스를 확인합니다.
            int selectedRowIndex = e.RowIndex;

            // 선택한 행의 데이터를 가져옵니다.
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

            // 각 셀의 값을 가져와서 텍스트박스에 할당합니다.
            textBox10.Text = selectedRow.Cells["Column10"].Value.ToString();
            textBox11.Text = selectedRow.Cells["Column11"].Value.ToString();
            // 필요에 따라 추가적인 텍스트박스에 대한 할당을 진행합니다.
            */

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dataGridView2.Rows.Add(textBox10.Text);

            // 데이터 입력 후 TextBox를 초기화합니다.
            //textBox10.Text = "ddddddddd";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //dataGridView2.Rows.Add("토리콤", "235555", "NHO3", "질산", "90L");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //dataGridView2.Rows.Add("토리콤", "230207001", "H2SO4", "황산", "120L");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add("토리콤", "235555", "NHO3", "질산", "90L");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add("토리콤", "230207001", "H2SO4", "황산", "120L");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string comboBox1Text = comboBox1.Text;
            string combobox4Text = comboBox4.Text;
            string combobox3Text = comboBox3.Text;
            string combobox6Text = comboBox6.Text;
            string combobox5Text = comboBox5.Text;
            string combobox2Text = comboBox2.Text;



            dataGridView1.Rows.Add(comboBox1Text, combobox4Text, combobox3Text, combobox6Text, "1.2 ph", "99%", "1%", combobox5Text, combobox2Text);

        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
                DataGridViewRow selectedRow = dataGridView2.Rows[dataGridView2.SelectedCells[0].RowIndex];

            // 선택된 행의 각 셀의 데이터를 TextBox에 할당합니다.
            label310.Text = selectedRow.Cells["Column310"].Value.ToString();
            label311.Text = selectedRow.Cells["Column311"].Value.ToString();
            label312.Text = selectedRow.Cells["Column312"].Value.ToString();
            label313.Text = selectedRow.Cells["Column313"].Value.ToString();
        }
    }
}
