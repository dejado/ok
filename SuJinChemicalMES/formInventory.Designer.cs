
namespace SuJinChemicalMES
{
    partial class formInventory
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column310 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column312 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column313 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column314 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.MedicineNum_com = new System.Windows.Forms.ComboBox();
            this.Acidity_com = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Registrant_bt = new System.Windows.Forms.Button();
            this.Code_lb = new System.Windows.Forms.Label();
            this.ProductName_lb = new System.Windows.Forms.Label();
            this.Company_lb = new System.Windows.Forms.Label();
            this.Medicine_com = new System.Windows.Forms.ComboBox();
            this.BathNum_com = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Re_bt = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "베스 가동 현황";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Location = new System.Drawing.Point(30, 80);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(606, 225);
            this.panel2.TabIndex = 17;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeight = 30;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column310,
            this.Column312,
            this.Column313,
            this.Column314});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(606, 225);
            this.dataGridView2.TabIndex = 6;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick_1);
            // 
            // Column310
            // 
            this.Column310.HeaderText = "회사명";
            this.Column310.MinimumWidth = 6;
            this.Column310.Name = "Column310";
            this.Column310.ReadOnly = true;
            this.Column310.Width = 81;
            // 
            // Column312
            // 
            this.Column312.HeaderText = "제품코드";
            this.Column312.MinimumWidth = 6;
            this.Column312.Name = "Column312";
            this.Column312.ReadOnly = true;
            this.Column312.Width = 96;
            // 
            // Column313
            // 
            this.Column313.HeaderText = "제품명";
            this.Column313.MinimumWidth = 6;
            this.Column313.Name = "Column313";
            this.Column313.ReadOnly = true;
            this.Column313.Width = 81;
            // 
            // Column314
            // 
            this.Column314.HeaderText = "수량";
            this.Column314.MinimumWidth = 6;
            this.Column314.Name = "Column314";
            this.Column314.ReadOnly = true;
            this.Column314.Width = 66;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.Re_bt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel1.Location = new System.Drawing.Point(30, 51);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 30);
            this.panel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "약품 목록";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(30, 348);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1203, 388);
            this.panel4.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column8,
            this.Column9,
            this.Column4});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1203, 388);
            this.dataGridView1.TabIndex = 33;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "베스번호";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 96;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.FillWeight = 150F;
            this.Column1.HeaderText = "약품종류";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.Width = 96;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "약품량";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 81;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "산도설정수치";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 126;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "베스가동상태";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 126;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "담당자";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 81;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "날짜";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 66;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel3.Location = new System.Drawing.Point(30, 319);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1203, 30);
            this.panel3.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "관리 설정";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.MedicineNum_com);
            this.panel5.Controls.Add(this.Acidity_com);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.Registrant_bt);
            this.panel5.Controls.Add(this.Code_lb);
            this.panel5.Controls.Add(this.ProductName_lb);
            this.panel5.Controls.Add(this.Company_lb);
            this.panel5.Controls.Add(this.Medicine_com);
            this.panel5.Controls.Add(this.BathNum_com);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Location = new System.Drawing.Point(648, 80);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(585, 225);
            this.panel5.TabIndex = 21;
            // 
            // MedicineNum_com
            // 
            this.MedicineNum_com.FormattingEnabled = true;
            this.MedicineNum_com.ItemHeight = 15;
            this.MedicineNum_com.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.MedicineNum_com.Location = new System.Drawing.Point(468, 114);
            this.MedicineNum_com.Name = "MedicineNum_com";
            this.MedicineNum_com.Size = new System.Drawing.Size(103, 23);
            this.MedicineNum_com.TabIndex = 58;
            // 
            // Acidity_com
            // 
            this.Acidity_com.FormattingEnabled = true;
            this.Acidity_com.ItemHeight = 15;
            this.Acidity_com.Items.AddRange(new object[] {
            "0.0~0.4 ph",
            "0.5~0.9 ph",
            "1.0~1.4 ph",
            "1.5~1.9 ph",
            "2.0~2.4 ph",
            "2.5~2.9 ph",
            "3.0~3.4 ph",
            "4.5~4.9 ph"});
            this.Acidity_com.Location = new System.Drawing.Point(466, 150);
            this.Acidity_com.Name = "Acidity_com";
            this.Acidity_com.Size = new System.Drawing.Size(103, 23);
            this.Acidity_com.TabIndex = 57;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.LightCyan;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(360, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 27);
            this.label10.TabIndex = 56;
            this.label10.Text = "산도설정";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Registrant_bt
            // 
            this.Registrant_bt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registrant_bt.Location = new System.Drawing.Point(375, 44);
            this.Registrant_bt.Name = "Registrant_bt";
            this.Registrant_bt.Size = new System.Drawing.Size(65, 25);
            this.Registrant_bt.TabIndex = 55;
            this.Registrant_bt.Text = "등록";
            this.Registrant_bt.UseVisualStyleBackColor = true;
            this.Registrant_bt.Click += new System.EventHandler(this.Registrant_bt_Click);
            // 
            // Code_lb
            // 
            this.Code_lb.BackColor = System.Drawing.Color.LightGray;
            this.Code_lb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Code_lb.Location = new System.Drawing.Point(106, 186);
            this.Code_lb.Name = "Code_lb";
            this.Code_lb.Size = new System.Drawing.Size(232, 27);
            this.Code_lb.TabIndex = 54;
            this.Code_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductName_lb
            // 
            this.ProductName_lb.BackColor = System.Drawing.Color.LightGray;
            this.ProductName_lb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductName_lb.Location = new System.Drawing.Point(106, 150);
            this.ProductName_lb.Name = "ProductName_lb";
            this.ProductName_lb.Size = new System.Drawing.Size(232, 27);
            this.ProductName_lb.TabIndex = 53;
            this.ProductName_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Company_lb
            // 
            this.Company_lb.BackColor = System.Drawing.Color.LightGray;
            this.Company_lb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Company_lb.Location = new System.Drawing.Point(106, 42);
            this.Company_lb.Name = "Company_lb";
            this.Company_lb.Size = new System.Drawing.Size(232, 27);
            this.Company_lb.TabIndex = 51;
            this.Company_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Medicine_com
            // 
            this.Medicine_com.FormattingEnabled = true;
            this.Medicine_com.ItemHeight = 15;
            this.Medicine_com.Items.AddRange(new object[] {
            "염산",
            "질산(NHO3)",
            "황산(H2SO4)",
            "알카리",
            "과산화수소(H2O2)",
            "불산(HF)",
            "염산(HCl)",
            "인산(H3PO4)",
            "암모니아(NH4OH)"});
            this.Medicine_com.Location = new System.Drawing.Point(106, 114);
            this.Medicine_com.Name = "Medicine_com";
            this.Medicine_com.Size = new System.Drawing.Size(232, 23);
            this.Medicine_com.TabIndex = 50;
            this.Medicine_com.SelectedIndexChanged += new System.EventHandler(this.Medicine_com_SelectedIndexChanged);
            // 
            // BathNum_com
            // 
            this.BathNum_com.FormattingEnabled = true;
            this.BathNum_com.ItemHeight = 15;
            this.BathNum_com.Items.AddRange(new object[] {
            "베스1호",
            "베스2호",
            "베스3호",
            "베스4호",
            "베스5호",
            "베스6호"});
            this.BathNum_com.Location = new System.Drawing.Point(106, 78);
            this.BathNum_com.Name = "BathNum_com";
            this.BathNum_com.Size = new System.Drawing.Size(232, 23);
            this.BathNum_com.TabIndex = 48;
            this.BathNum_com.SelectedIndexChanged += new System.EventHandler(this.BathNum_com_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(20, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 20);
            this.label14.TabIndex = 42;
            this.label14.Text = "기본정보";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.LightCyan;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 27);
            this.label9.TabIndex = 49;
            this.label9.Text = "제품코드";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightCyan;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 27);
            this.label4.TabIndex = 41;
            this.label4.Text = "회사명";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.LightCyan;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 27);
            this.label5.TabIndex = 43;
            this.label5.Text = "베스넘버";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.LightCyan;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 27);
            this.label6.TabIndex = 44;
            this.label6.Text = "약품종류";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.LightCyan;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 27);
            this.label8.TabIndex = 46;
            this.label8.Text = "제품명";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.LightCyan;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(360, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 27);
            this.label11.TabIndex = 47;
            this.label11.Text = "약품투입량";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel6.Controls.Add(this.label3);
            this.panel6.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel6.Location = new System.Drawing.Point(648, 51);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(585, 30);
            this.panel6.TabIndex = 20;
            // 
            // Re_bt
            // 
            this.Re_bt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Re_bt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Re_bt.Location = new System.Drawing.Point(459, 0);
            this.Re_bt.Margin = new System.Windows.Forms.Padding(2);
            this.Re_bt.Name = "Re_bt";
            this.Re_bt.Size = new System.Drawing.Size(145, 28);
            this.Re_bt.TabIndex = 26;
            this.Re_bt.Text = "새로고침";
            this.Re_bt.UseVisualStyleBackColor = true;
            this.Re_bt.Click += new System.EventHandler(this.Re_bt_Click);
            // 
            // formInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1263, 758);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formInventory";
            this.Text = "회사명";
            this.Load += new System.EventHandler(this.formInventory_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column310;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column312;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column313;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column314;
        private System.Windows.Forms.ComboBox MedicineNum_com;
        private System.Windows.Forms.ComboBox Acidity_com;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Registrant_bt;
        private System.Windows.Forms.Label Code_lb;
        private System.Windows.Forms.Label ProductName_lb;
        private System.Windows.Forms.Label Company_lb;
        private System.Windows.Forms.ComboBox Medicine_com;
        private System.Windows.Forms.ComboBox BathNum_com;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button Re_bt;
    }
}