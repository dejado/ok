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
            ShowLoadingRateGraph();
            ShowProgressGraph();
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
        private void ShowProgressGraph()
        {
            string connectionString1 = "Server = 10.10.32.82; Database=accumulated_data;Uid=team;Pwd=team1234";
            var 부품수량 = Get부품수량(connectionString1);
            Dictionary<string, int> 출고부품수량 = 부품수량.ToDictionary(kv => kv.Key, kv => kv.Value.ShipmentQuantity);
            Dictionary<string, int> 입고부품수량 = 부품수량.ToDictionary(kv => kv.Key, kv => kv.Value.IncomingQuantity);
            DrawChart(ProgressChart, 출고부품수량, 입고부품수량);
        }
        private void DrawChart(Chart chart, Dictionary<string, int> 출고부품수량, Dictionary<string, int> 입고부품수량)
        {
            HashSet<string> 회사목록 = new HashSet<string>(출고부품수량.Keys);
            회사목록.UnionWith(입고부품수량.Keys);
            Dictionary<string, double> 진행률 = new Dictionary<string, double>();


            foreach (string 회사명 in 회사목록)
            {
                int 출고수량 = 출고부품수량.ContainsKey(회사명) ? 출고부품수량[회사명] : 0;
                int 입고수량 = 입고부품수량.ContainsKey(회사명) ? 입고부품수량[회사명] : 0;

                double 회사진행률 = 0; // 기본값으로 초기화

                // 입고수량이 0이 아닌 경우에만 진행률을 계산
                if (입고수량 != 0)
                {
                    회사진행률 = Math.Min((double)출고수량 / 입고수량 * 100, 100); // 최대 100%

                }

                진행률.Add(회사명, 회사진행률);
            }


            Series barSeries1 = chart.Series.Add("입고수량_막대");
            barSeries1.ChartType = SeriesChartType.Column;
            barSeries1.LegendText = "입고수량";
            foreach (var item in 입고부품수량)
            {
                barSeries1.Points.AddXY(item.Key, item.Value);
            }

            Series barSeries2 = chart.Series.Add("출고수량_막대");
            barSeries2.ChartType = SeriesChartType.Column;
            barSeries2.LegendText = "출고수량";

            foreach (var item in 출고부품수량)
            {
                barSeries2.Points.AddXY(item.Key, item.Value);
            }

            Series progressSeries = chart.Series.Add("진행률");
            progressSeries.ChartType = SeriesChartType.Line;
            progressSeries.Color = Color.Black;
            progressSeries.BorderWidth = 2; //두께
            chart.Series["입고수량_막대"]["PixelPointWidth"] = "50";
            chart.Series["출고수량_막대"]["PixelPointWidth"] = "50";

            foreach (var item in 진행률)
            {
                double roundedProgress = Math.Round(item.Value, 1); // 진행률을 소수점 한 자리로 반올림
                progressSeries.Points.AddXY(item.Key, roundedProgress);
                progressSeries.Points[progressSeries.Points.Count - 1].Label = $"{roundedProgress}%"; // 데이터 값에 % 추가
                progressSeries.Points[progressSeries.Points.Count - 1].LabelForeColor = Color.Black; // 주석 텍스트 색상 설정
                progressSeries.Points[progressSeries.Points.Count - 1].LabelBackColor = Color.Transparent; // 주석 배경색 설정
            }

            chart.ChartAreas[0].AxisY2.Enabled = AxisEnabled.True;
            chart.ChartAreas[0].AxisY2.Maximum = 100;

            barSeries1.YAxisType = AxisType.Primary;
            barSeries2.YAxisType = AxisType.Primary;
            progressSeries.YAxisType = AxisType.Secondary;

            chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart.ChartAreas[0].AxisY2.MajorGrid.Enabled = false;

            chart.DataBind();
            chart.Titles.Add("작업진행율").Font = new Font("Arial", 16, FontStyle.Bold);

            Legend legend = chart.Legends.Add("범례");
            legend.Docking = Docking.Bottom;
        }

        private static Dictionary<string, (int IncomingQuantity, int ShipmentQuantity)> Get부품수량(string connectionString)
        {
            Dictionary<string, (int IncomingQuantity, int ShipmentQuantity)> 부품수량 = new Dictionary<string, (int IncomingQuantity, int ShipmentQuantity)>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string incomingQuery = @"
                    SELECT 
                        b.supplier AS company, 
                        SUM(CASE WHEN a.progress = '입고' THEN a.quantity ELSE 0 END) AS incoming_quantity 
                    FROM 
                        accumulated_data a
                    JOIN 
                        accumulated_data b ON a.lot_no = b.lot_no AND b.progress = '발주서등록'
                    WHERE 
                        a.progress = '입고'
                    GROUP BY 
                        b.supplier;";

                string shipmentQuery = @"
                 SELECT 
                   supplier AS company, 
                   SUM(CASE WHEN progress = '출고' THEN quantity ELSE 0 END) AS shipment_quantity 
                 FROM 
                   accumulated_data 
                 WHERE 
                 progress = '출고'
                 GROUP BY 
                 supplier";

                MySqlCommand incomingCommand = new MySqlCommand(incomingQuery, connection);
                MySqlCommand shipmentCommand = new MySqlCommand(shipmentQuery, connection);

                connection.Open();

                using (MySqlDataReader incomingReader = incomingCommand.ExecuteReader())
                {
                    while (incomingReader.Read())
                    {
                        string 회사명 = incomingReader.GetString(0);
                        int 입고수량 = incomingReader.GetInt32(1);

                        if (부품수량.ContainsKey(회사명))
                        {
                            (int IncomingQuantity, int ShipmentQuantity) existingValues = 부품수량[회사명];
                            부품수량[회사명] = (IncomingQuantity: 입고수량, ShipmentQuantity: existingValues.ShipmentQuantity);
                        }
                        else
                        {
                            부품수량.Add(회사명, (IncomingQuantity: 입고수량, ShipmentQuantity: 0));
                        }
                    }
                }
                using (MySqlDataReader shipmentReader = shipmentCommand.ExecuteReader())
                {
                    while (shipmentReader.Read())
                    {
                        string 회사명 = shipmentReader.GetString(0);
                        int 출고수량 = shipmentReader.GetInt32(1);

                        if (부품수량.ContainsKey(회사명))
                        {
                            (int IncomingQuantity, int ShipmentQuantity) existingValues = 부품수량[회사명];
                            부품수량[회사명] = (IncomingQuantity: existingValues.IncomingQuantity, ShipmentQuantity: 출고수량);
                        }
                        else
                        {
                            부품수량.Add(회사명, (IncomingQuantity: 0, ShipmentQuantity: 출고수량));
                        }
                    }
                }

                return 부품수량;
            }
        }

        private void ShowLoadingRateGraph() //적재, incoming테이블과 shipment 테이블의 location 데이터 숫자 합산하면 됨.
        {
            string connectionString2 = "Server = 10.10.32.82; Database=material;Uid=team;Pwd=team1234;";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString2))
                {
                    connection.Open();

                    int 양품_총용량 = 400000;
                    int 부자재_총용량 = 300000;
                    int 반품_총용량 = 3000;
                    string query = @"
                  SELECT
                        SUM(CASE WHEN location = '양품IA' THEN quantity ELSE 0 END) AS 양품IA_총수량,
                        SUM(CASE WHEN location = '부자재IB' THEN quantity ELSE 0 END) AS 부자재IB_총수량,
                        SUM(CASE WHEN location = '반품' THEN quantity ELSE 0 END) AS 반품_총수량
                    FROM
                        incoming;";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int 양품IA_총수량 = Convert.ToInt32(reader["양품IA_총수량"]);
                                int 부자재IB_총수량 = Convert.ToInt32(reader["부자재IB_총수량"]);
                                int 반품_총수량 = Convert.ToInt32(reader["반품_총수량"]);
                                double 양품_적재율 = Convert.ToDouble(reader["양품IA_총수량"]) / 양품_총용량;
                                double 부자재_적재율 = Convert.ToDouble(reader["부자재IB_총수량"]) / 부자재_총용량;
                                double 반품_적재율 = Convert.ToDouble(reader["반품_총수량"]) / 반품_총용량;
                                WarehouseChart1.Controls.Add(CreateDoughnutChart1("양품", 양품_적재율));
                                WarehouseChart2.Controls.Add(CreateDoughnutChart2("부자재", 부자재_적재율));
                                WarehouseChart3.Controls.Add(CreateDoughnutChart3("반품", 반품_적재율));
                            }
                        }
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private Chart CreateDoughnutChart1(string title, double loadingRate)
        {
            Chart chart = new Chart();

            chart.Dock = DockStyle.Fill;
            chart.ChartAreas.Add("ChartArea");
            Series warehouseSeries = chart.Series.Add("Series");
            warehouseSeries.ChartType = SeriesChartType.Doughnut;

            double loadedPercentage = Math.Min(loadingRate * 100, 100); // 적재율이 100%를 초과하지 않도록 제한

            warehouseSeries.Points.Add(loadedPercentage);
            warehouseSeries.Points.Add(100 - loadedPercentage); // 여유 공간


            warehouseSeries.Points[0].Label = string.Format("{0:F1}%", loadedPercentage);

            chart.Legends.Add(new Legend("적재율"));
            warehouseSeries.Points[0].LegendText = "적재율";
            chart.Legends["적재율"].Docking = Docking.Bottom;
            warehouseSeries.Points[1].LegendText = "여유공간";
            //  warehouseSeries.Points[1].Label = string.Format("{0:F1}%", 100 - loadedPercentage);

            Title chartTitle = new Title();
            chartTitle.Text = title;
            chart.Titles.Add(chartTitle);
            chartTitle.Font = new Font("Arial", 16, FontStyle.Bold);
            warehouseSeries.Points[0].Color = Color.Red;
            return chart;

        }
        private Chart CreateDoughnutChart2(string title, double loadingRate)
        {
            Chart chart = new Chart();

            chart.Dock = DockStyle.Fill;
            chart.ChartAreas.Add("ChartArea");
            Series warehouseSeries = chart.Series.Add("Series");
            warehouseSeries.ChartType = SeriesChartType.Doughnut;

            double loadedPercentage = Math.Min(loadingRate * 100, 100);

            warehouseSeries.Points.Add(loadedPercentage);
            warehouseSeries.Points.Add(100 - loadedPercentage); // 여유 공간

            warehouseSeries.Points[0].Label = string.Format("{0:F1}%", loadedPercentage);
            warehouseSeries.Points[1].Label = string.Format("{0:F1}%", 100 - loadedPercentage);

            Title chartTitle = new Title();
            chartTitle.Text = title;
            chart.Titles.Add(chartTitle);
            chartTitle.Font = new Font("Arial", 16, FontStyle.Bold);

            return chart;
        }
        private Chart CreateDoughnutChart3(string title, double loadingRate)
        {
            Chart chart = new Chart();

            chart.Dock = DockStyle.Fill;
            chart.ChartAreas.Add("ChartArea");
            Series warehouseSeries = chart.Series.Add("Series");
            warehouseSeries.ChartType = SeriesChartType.Doughnut;

            double loadedPercentage = Math.Min(loadingRate * 100, 100);
            warehouseSeries.Points.Add(loadedPercentage);
            warehouseSeries.Points.Add(100 - loadedPercentage); // 여유 공간

            warehouseSeries.Points[0].Label = string.Format("{0:F1}%", loadedPercentage);
            warehouseSeries.Points[1].Label = string.Format("{0:F1}%", 100 - loadedPercentage);

            Title chartTitle = new Title();
            chartTitle.Text = title;
            chart.Titles.Add(chartTitle);
            chartTitle.Font = new Font("Arial", 16, FontStyle.Bold);
            return chart;
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

