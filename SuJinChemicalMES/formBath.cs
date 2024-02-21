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
    public partial class formBath : Form
    {

        private string secondCharacter;

        public formBath()
        {
            InitializeComponent();

        }

        public void SetSecondCharacter(string character)
        {
            secondCharacter = character;
            DisplayDataBasedOnSecondCharacter();
        }

        private void DisplayDataBasedOnSecondCharacter()
        {
            try
            {
                string connectionInspection = "Server=10.10.32.82;Database=production_management;Uid=team;Pwd=team1234;";
                using (MySqlConnection connection2 = new MySqlConnection(connectionInspection))
                {
                    connection2.Open();

                    string Query2 = $"SELECT * FROM working WHERE SUBSTRING(bath, 3, 1) = '{secondCharacter}'";
                    MySqlCommand command2 = new MySqlCommand(Query2, connection2);
                    MySqlDataReader reader2 = command2.ExecuteReader();

                    while (reader2.Read())
                    {
                        bath.Text = reader2[0].ToString() + "\n"
                            + reader2[1].ToString() + "\n"
                            + reader2[2].ToString() + "\n"
                            + reader2[3].ToString() + "\n"
                            + reader2[4].ToString() + "\n"
                            + reader2[5].ToString() + "\n"
                            + reader2[6].ToString() + "\n"
                            + reader2[7].ToString() + "\n"
                            + reader2[8].ToString() + "\n"
                            + reader2[9].ToString() + "\n";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("데이터 로드 중 오류 발생: " + ex.Message);
            }
        }

        private void bath_Click(object sender, EventArgs e)
        {

        }
    }
}
