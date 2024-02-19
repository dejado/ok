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
using System.Windows.Forms.DataVisualization.Charting;

namespace SuJinChemicalMES
{
    public partial class formChart : Form
    {
        public formChart()
        {
            InitializeComponent();
            ShowDefectGraph();
            ShowDefectText();
        }

        private void formChart_Load(object sender, EventArgs e)
        {
            /*       this.ControlBox = false;
                   //Load sample data
                   var sampleData1 = new MLModel1.ModelInput()
                   {
                       VibrationNum = 1.3188805F,
                       HeightNum = 500.3159F,
                       VibrationBinary = 0F,
                       HeightBinary = 0F,
                   };
                   var sampleData2 = new MLModel1.ModelInput()
                   {
                       VibrationNum = 0.3188805F,
                       HeightNum = 500.3159F,
                       VibrationBinary = 1F,
                       HeightBinary = 0F,
                   };
                   var sampleData3 = new MLModel1.ModelInput()
                   {
                       VibrationNum = 1.3188805F,
                       HeightNum = 500.3159F,
                       VibrationBinary = 1F,
                       HeightBinary = 0F,
                   };
                   var sampleData4 = new MLModel1.ModelInput()
                   {
                       VibrationNum = 0.3188805F,
                       HeightNum = 575.3159F,
                       VibrationBinary = 0F,
                       HeightBinary = 0F,
                   };
                   var sampleData5 = new MLModel1.ModelInput()
                   {
                       VibrationNum = 0.3188805F,
                       HeightNum = 575.3159F,
                       VibrationBinary = 0F,
                       HeightBinary = 1F,
                   };
                   var sampleData6 = new MLModel1.ModelInput()
                   {
                       VibrationNum = 0.3188805F,
                       HeightNum = 500.3159F,
                       VibrationBinary = 0F,
                       HeightBinary = 0F,
                   };



                   var sampleData12 = new MLModel2.ModelInput()
                   {
                       VibrationNum = 1.3188805F,
                       HeightNum = 500.3159F,
                       VibrationBinary = 0F,
                       HeightBinary = 0F,
                   };
                   var sampleData11 = new MLModel2.ModelInput()
                   {
                       VibrationNum = 0.3188805F,
                       HeightNum = 500.3159F,
                       VibrationBinary = 1F,
                       HeightBinary = 0F,
                   };
                   var sampleData10 = new MLModel2.ModelInput()
                   {
                       VibrationNum = 1.3188805F,
                       HeightNum = 500.3159F,
                       VibrationBinary = 1F,
                       HeightBinary = 0F,
                   };
                   var sampleData9 = new MLModel2.ModelInput()
                   {
                       VibrationNum = 0.3188805F,
                       HeightNum = 575.3159F,
                       VibrationBinary = 0F,
                       HeightBinary = 0F,
                   };
                   var sampleData8 = new MLModel2.ModelInput()
                   {
                       VibrationNum = 0.3188805F,
                       HeightNum = 575.3159F,
                       VibrationBinary = 0F,
                       HeightBinary = 1F,
                   };
                   var sampleData7 = new MLModel2.ModelInput()
                   {
                       VibrationNum = 0.3188805F,
                       HeightNum = 500.3159F,
                       VibrationBinary = 0F,
                       HeightBinary = 0F,
                   };
                   //Load model and predict output
                   var result1 = MLModel1.Predict(sampleData1);
                   var result2 = MLModel1.Predict(sampleData2);
                   var result3 = MLModel1.Predict(sampleData3);
                   var result4 = MLModel1.Predict(sampleData4);
                   var result5 = MLModel1.Predict(sampleData5);
                   var result6 = MLModel1.Predict(sampleData6);

                   var result12 = MLModel2.Predict(sampleData12);
                   var result11 = MLModel2.Predict(sampleData11);
                   var result10 = MLModel2.Predict(sampleData10);
                   var result9 = MLModel2.Predict(sampleData9);
                   var result8 = MLModel2.Predict(sampleData8);
                   var result7 = MLModel2.Predict(sampleData7);

                   label1.Text = result1.Score.ToString();
                   label2.Text = result2.Score.ToString();
                   label3.Text = result3.Score.ToString();
                   label4.Text = result4.Score.ToString();
                   label5.Text = result5.Score.ToString();
                   label6.Text = result6.Score.ToString();


                   string machine1 = result12.Score.ToString();
                   string machine2 = result11.Score.ToString();
                   string machine3 = result10.Score.ToString();
                   string machine4 = result9.Score.ToString();
                   string machine5 = result8.Score.ToString();
                   string machine6 = result7.Score.ToString();


                   label12.Text = result12.Score.ToString();
                   label11.Text = result11.Score.ToString();
                   label10.Text = result10.Score.ToString();
                   label9.Text = result9.Score.ToString();
                   label8.Text = result8.Score.ToString();
                   label7.Text = result7.Score.ToString();*/
        }

        private void ShowDefectText()
        {
            string connectionString = "Server = 10.10.32.82; Database=accumulated_data;Uid=team;Pwd=team1234;";
            Dictionary<string, int> defectCounts = new Dictionary<string, int>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT cause_of_defect FROM accumulated_data WHERE cause_of_defect IS NOT NULL AND cause_of_defect <> ''";

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string cause = reader["cause_of_defect"].ToString();
                        if (!defectCounts.ContainsKey(cause))
                        {
                            defectCounts[cause] = 1; // 새로운 불량 원인이면 1로 초기화
                        }
                        else
                        {
                            defectCounts[cause]++; // 기존에 있는 불량 원인이면 카운트 증가
                        }
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            // 불량 원인을 발생 빈도순으로 정렬
            var sortedDefects = defectCounts.OrderByDescending(pair => pair.Value);
            TextBox textBoxDefect = new TextBox();
            textBoxDefect.Multiline = true;
            textBoxDefect.ReadOnly = true;
            textBoxDefect.ScrollBars = ScrollBars.Vertical;
            textBoxDefect.Dock = DockStyle.Fill;

            textBoxDefect.Location = new Point(10, 10);
            textBoxDefect.Enabled = false;
            textBoxDefect.Font = new Font("Arial", 15, FontStyle.Bold);
            textBoxDefect.ForeColor = Color.Black;
            textBoxDefect.BackColor = Color.White;

            int rank = 1;
            foreach (var defect in sortedDefects)
            {
                string causeWithRank = $"{rank}. {defect.Key} ({defect.Value}건)";
                textBoxDefect.Text += causeWithRank + Environment.NewLine;
                rank++;
            }

            DefectPn.Controls.Add(textBoxDefect);
            this.ActiveControl = null;
        }

        private void ShowDefectGraph()   //결함 원인 
        {
            string connectionString = "Server = 10.10.32.82; Database=accumulated_data;Uid=team;Pwd=team1234;";
            List<string> highDefectCompanies = new List<string>();
            Chart chart = new Chart();
            chart.ChartAreas.Add("ChartArea");
            chart.Dock = DockStyle.Fill;

            Series DefectSeries = chart.Series.Add("DefectRate");
            DefectSeries.ChartType = SeriesChartType.Column;
            chart.Series["DefectRate"]["PixelPointWidth"] = "30";
            chart.ChartAreas["ChartArea"].AxisY.LabelStyle.Format = "{0}%";

            chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = @"
                SELECT supplier, 
                       COALESCE(SUM(CASE WHEN Progress = '출하검사완료' AND Test_Results = 'F' THEN Quantity ELSE 0 END), 0) AS ShipmentDefectQuantity,
                       COALESCE(SUM(CASE WHEN Progress = '출하검사완료' THEN Quantity ELSE 0 END), 0) AS TotalShipmentQuantity
                FROM accumulated_data
                GROUP BY supplier
                HAVING TotalShipmentQuantity > 0";


                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string supplier = reader.GetString("supplier");
                                int shipmentDefectQuantity = reader.GetInt32("ShipmentDefectQuantity");
                                int totalShipmentQuantity = reader.GetInt32("TotalShipmentQuantity");

                                double defectRate = totalShipmentQuantity != 0 ? ((double)shipmentDefectQuantity / totalShipmentQuantity) * 100 : 0;

                                chart.Series["DefectRate"].Points.AddXY(supplier, defectRate);

                                if (defectRate > 1.5)
                                {
                                    highDefectCompanies.Add(supplier);
                                    chart.Series["DefectRate"].Points.Last().Color = Color.Red;

                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            chart.ChartAreas["ChartArea"].AxisY.Interval = 1;
            chart.ChartAreas["ChartArea"].AxisY.Maximum = 3;
            chart.Titles.Add("불량률").Font = new Font("Arial", 16, FontStyle.Bold);
            TextBox textAlarm = new TextBox();
            textAlarm.Multiline = true;
            textAlarm.Enabled = false;
            textAlarm.ReadOnly = true;
            textAlarm.Dock = DockStyle.Fill;
            textAlarm.Font = new Font("Arial", 12, FontStyle.Bold);
            textAlarm.ForeColor = Color.Black;
            textAlarm.BackColor = Color.White;
            textAlarm.TabStop = false;
            // 불량률 1.5% 추가
            if (highDefectCompanies.Count == 0)
            {
                textAlarm.Text = "불량률 문제 없음";
            }

            else
            {
                foreach (string company in highDefectCompanies)
                {
                    textAlarm.Text += $"{company}{Environment.NewLine}불량률이 1.5% 초과{Environment.NewLine}{Environment.NewLine}";

                }
            }
            DefectChart.Controls.Add(chart);
            AlarmPn.Controls.Add(textAlarm);
        }
    }
}

