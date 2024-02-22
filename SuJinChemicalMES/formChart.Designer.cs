
namespace SuJinChemicalMES
{
    partial class formChart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Load_bt = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.AlarmPn = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DefectPn = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.DefectChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ProgressChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.WarehouseChart3 = new System.Windows.Forms.Panel();
            this.WarehouseChart1 = new System.Windows.Forms.Panel();
            this.WarehouseChart2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DefectChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressChart)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.0687F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.9313F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.DefectChart, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ProgressChart, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1263, 758);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(781, 421);
            this.panel4.Margin = new System.Windows.Forms.Padding(10, 42, 29, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(453, 24);
            this.panel4.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "불량률 이상";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "결함원인";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(26, 421);
            this.panel3.Margin = new System.Windows.Forms.Padding(26, 42, 5, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(740, 24);
            this.panel3.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.Load_bt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(781, 42);
            this.panel2.Margin = new System.Windows.Forms.Padding(10, 42, 29, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(453, 24);
            this.panel2.TabIndex = 6;
            // 
            // Load_bt
            // 
            this.Load_bt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Load_bt.Location = new System.Drawing.Point(375, 1);
            this.Load_bt.Name = "Load_bt";
            this.Load_bt.Size = new System.Drawing.Size(75, 23);
            this.Load_bt.TabIndex = 0;
            this.Load_bt.Text = "새로고침";
            this.Load_bt.UseVisualStyleBackColor = true;
            this.Load_bt.Click += new System.EventHandler(this.Load_bt_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.AlarmPn, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(781, 445);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(10, 0, 29, 32);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 281F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(453, 281);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // AlarmPn
            // 
            this.AlarmPn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AlarmPn.ForeColor = System.Drawing.Color.White;
            this.AlarmPn.Location = new System.Drawing.Point(0, 0);
            this.AlarmPn.Margin = new System.Windows.Forms.Padding(0);
            this.AlarmPn.Name = "AlarmPn";
            this.AlarmPn.Size = new System.Drawing.Size(226, 281);
            this.AlarmPn.TabIndex = 5;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.panel6, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.DefectPn, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.panel5, 0, 2);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(226, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(227, 281);
            this.tableLayoutPanel5.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel6.Controls.Add(this.label1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 125);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(227, 30);
            this.panel6.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "베스 고장예측";
            // 
            // DefectPn
            // 
            this.DefectPn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DefectPn.Location = new System.Drawing.Point(0, 0);
            this.DefectPn.Margin = new System.Windows.Forms.Padding(0);
            this.DefectPn.Name = "DefectPn";
            this.DefectPn.Size = new System.Drawing.Size(227, 125);
            this.DefectPn.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 155);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(227, 126);
            this.panel5.TabIndex = 6;
            // 
            // DefectChart
            // 
            chartArea1.Name = "ChartArea1";
            this.DefectChart.ChartAreas.Add(chartArea1);
            this.DefectChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DefectChart.Location = new System.Drawing.Point(26, 445);
            this.DefectChart.Margin = new System.Windows.Forms.Padding(26, 0, 5, 32);
            this.DefectChart.Name = "DefectChart";
            this.DefectChart.Size = new System.Drawing.Size(740, 281);
            this.DefectChart.TabIndex = 3;
            this.DefectChart.Text = "chart3";
            // 
            // ProgressChart
            // 
            chartArea2.Name = "ChartArea1";
            this.ProgressChart.ChartAreas.Add(chartArea2);
            this.ProgressChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProgressChart.Enabled = false;
            this.ProgressChart.Location = new System.Drawing.Point(26, 66);
            this.ProgressChart.Margin = new System.Windows.Forms.Padding(26, 0, 5, 0);
            this.ProgressChart.Name = "ProgressChart";
            this.ProgressChart.Size = new System.Drawing.Size(740, 313);
            this.ProgressChart.TabIndex = 0;
            this.ProgressChart.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(26, 42);
            this.panel1.Margin = new System.Windows.Forms.Padding(26, 42, 5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 24);
            this.panel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(781, 66);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(10, 0, 29, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(453, 313);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanel4.Controls.Add(this.WarehouseChart3, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.WarehouseChart1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.WarehouseChart2, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(10, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(10, 0, 29, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(414, 313);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // WarehouseChart3
            // 
            this.WarehouseChart3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WarehouseChart3.Location = new System.Drawing.Point(274, 0);
            this.WarehouseChart3.Margin = new System.Windows.Forms.Padding(0);
            this.WarehouseChart3.Name = "WarehouseChart3";
            this.WarehouseChart3.Size = new System.Drawing.Size(140, 313);
            this.WarehouseChart3.TabIndex = 2;
            // 
            // WarehouseChart1
            // 
            this.WarehouseChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WarehouseChart1.Location = new System.Drawing.Point(0, 0);
            this.WarehouseChart1.Margin = new System.Windows.Forms.Padding(0);
            this.WarehouseChart1.Name = "WarehouseChart1";
            this.WarehouseChart1.Size = new System.Drawing.Size(137, 313);
            this.WarehouseChart1.TabIndex = 0;
            // 
            // WarehouseChart2
            // 
            this.WarehouseChart2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WarehouseChart2.Location = new System.Drawing.Point(137, 0);
            this.WarehouseChart2.Margin = new System.Windows.Forms.Padding(0);
            this.WarehouseChart2.Name = "WarehouseChart2";
            this.WarehouseChart2.Size = new System.Drawing.Size(137, 313);
            this.WarehouseChart2.TabIndex = 2;
            // 
            // formChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1263, 758);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formChart";
            this.Text = "formChart";
            this.Load += new System.EventHandler(this.formChart_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DefectChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressChart)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel AlarmPn;
        private System.Windows.Forms.DataVisualization.Charting.Chart DefectChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart ProgressChart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel WarehouseChart3;
        private System.Windows.Forms.Panel WarehouseChart1;
        private System.Windows.Forms.Panel WarehouseChart2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Panel DefectPn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Load_bt;
    }
}