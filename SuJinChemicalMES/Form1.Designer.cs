﻿
namespace SuJinChemicalMES
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnham = new FontAwesome.Sharp.IconButton();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnMain = new System.Windows.Forms.Panel();
            this.Main = new FontAwesome.Sharp.IconButton();
            this.pnIn = new System.Windows.Forms.Panel();
            this.Input = new FontAwesome.Sharp.IconButton();
            this.pnQC = new System.Windows.Forms.Panel();
            this.Qc = new FontAwesome.Sharp.IconButton();
            this.menuContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Wokrview = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Workmain = new FontAwesome.Sharp.IconButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Inventory = new FontAwesome.Sharp.IconButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Plan = new FontAwesome.Sharp.IconButton();
            this.pnOut = new System.Windows.Forms.Panel();
            this.Output = new FontAwesome.Sharp.IconButton();
            this.pnChart = new System.Windows.Forms.Panel();
            this.Chart = new FontAwesome.Sharp.IconButton();
            this.pnSystem = new System.Windows.Forms.FlowLayoutPanel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.Systemmain = new FontAwesome.Sharp.IconButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.System1 = new FontAwesome.Sharp.IconButton();
            this.panel9 = new System.Windows.Forms.Panel();
            this.System2 = new FontAwesome.Sharp.IconButton();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.System3 = new FontAwesome.Sharp.IconButton();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.System4 = new FontAwesome.Sharp.IconButton();
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.menuTransition2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.pnMain.SuspendLayout();
            this.pnIn.SuspendLayout();
            this.pnQC.SuspendLayout();
            this.menuContainer.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.pnOut.SuspendLayout();
            this.pnChart.SuspendLayout();
            this.pnSystem.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GreenYellow;
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnMaximize);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnham);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1500, 42);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.Black;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 30;
            this.btnMinimize.Location = new System.Drawing.Point(1408, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(26, 33);
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.btnMaximize.IconColor = System.Drawing.Color.Black;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 30;
            this.btnMaximize.Location = new System.Drawing.Point(1436, 6);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(28, 33);
            this.btnMaximize.TabIndex = 4;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.TimesRectangle;
            this.btnExit.IconColor = System.Drawing.Color.Black;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 30;
            this.btnExit.Location = new System.Drawing.Point(1467, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(27, 33);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.mesclose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "TEAM4 | SUJIN CHAMICAL | MES";
            // 
            // btnham
            // 
            this.btnham.FlatAppearance.BorderSize = 0;
            this.btnham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnham.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            this.btnham.IconColor = System.Drawing.Color.Black;
            this.btnham.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnham.IconSize = 30;
            this.btnham.Location = new System.Drawing.Point(14, 3);
            this.btnham.Name = "btnham";
            this.btnham.Size = new System.Drawing.Size(46, 36);
            this.btnham.TabIndex = 2;
            this.btnham.UseVisualStyleBackColor = true;
            this.btnham.Click += new System.EventHandler(this.btnham_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.sidebar.Controls.Add(this.pnMain);
            this.sidebar.Controls.Add(this.pnIn);
            this.sidebar.Controls.Add(this.pnQC);
            this.sidebar.Controls.Add(this.menuContainer);
            this.sidebar.Controls.Add(this.pnOut);
            this.sidebar.Controls.Add(this.pnChart);
            this.sidebar.Controls.Add(this.pnSystem);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sidebar.Location = new System.Drawing.Point(0, 42);
            this.sidebar.Name = "sidebar";
            this.sidebar.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.sidebar.Size = new System.Drawing.Size(237, 758);
            this.sidebar.TabIndex = 1;
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.Main);
            this.pnMain.Location = new System.Drawing.Point(3, 33);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(233, 45);
            this.pnMain.TabIndex = 3;
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.Main.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main.ForeColor = System.Drawing.Color.GreenYellow;
            this.Main.IconChar = FontAwesome.Sharp.IconChar.House;
            this.Main.IconColor = System.Drawing.Color.GreenYellow;
            this.Main.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Main.IconSize = 32;
            this.Main.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Main.Location = new System.Drawing.Point(-4, -17);
            this.Main.Name = "Main";
            this.Main.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Main.Size = new System.Drawing.Size(253, 84);
            this.Main.TabIndex = 4;
            this.Main.Text = "           메인";
            this.Main.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Main.UseVisualStyleBackColor = false;
            this.Main.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // pnIn
            // 
            this.pnIn.Controls.Add(this.Input);
            this.pnIn.Location = new System.Drawing.Point(3, 84);
            this.pnIn.Name = "pnIn";
            this.pnIn.Size = new System.Drawing.Size(233, 45);
            this.pnIn.TabIndex = 3;
            // 
            // Input
            // 
            this.Input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.Input.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input.ForeColor = System.Drawing.Color.GreenYellow;
            this.Input.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
            this.Input.IconColor = System.Drawing.Color.GreenYellow;
            this.Input.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Input.IconSize = 32;
            this.Input.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Input.Location = new System.Drawing.Point(-4, -19);
            this.Input.Name = "Input";
            this.Input.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Input.Size = new System.Drawing.Size(253, 84);
            this.Input.TabIndex = 4;
            this.Input.Text = "           자재";
            this.Input.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Input.UseVisualStyleBackColor = false;
            this.Input.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // pnQC
            // 
            this.pnQC.Controls.Add(this.Qc);
            this.pnQC.Location = new System.Drawing.Point(3, 135);
            this.pnQC.Name = "pnQC";
            this.pnQC.Size = new System.Drawing.Size(233, 45);
            this.pnQC.TabIndex = 3;
            // 
            // Qc
            // 
            this.Qc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.Qc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qc.ForeColor = System.Drawing.Color.GreenYellow;
            this.Qc.IconChar = FontAwesome.Sharp.IconChar.Microscope;
            this.Qc.IconColor = System.Drawing.Color.GreenYellow;
            this.Qc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Qc.IconSize = 32;
            this.Qc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Qc.Location = new System.Drawing.Point(-4, -19);
            this.Qc.Name = "Qc";
            this.Qc.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Qc.Size = new System.Drawing.Size(253, 84);
            this.Qc.TabIndex = 4;
            this.Qc.Text = "           품질";
            this.Qc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Qc.UseVisualStyleBackColor = false;
            //this.Qc.Click += new System.EventHandler(this.Qc_Click);
            // 
            // menuContainer
            // 
            this.menuContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.menuContainer.Controls.Add(this.panel3);
            this.menuContainer.Controls.Add(this.panel2);
            this.menuContainer.Controls.Add(this.panel7);
            this.menuContainer.Controls.Add(this.panel6);
            this.menuContainer.Location = new System.Drawing.Point(0, 183);
            this.menuContainer.Margin = new System.Windows.Forms.Padding(0);
            this.menuContainer.Name = "menuContainer";
            this.menuContainer.Size = new System.Drawing.Size(233, 45);
            this.menuContainer.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Wokrview);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(233, 45);
            this.panel3.TabIndex = 3;
            // 
            // Wokrview
            // 
            this.Wokrview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.Wokrview.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wokrview.ForeColor = System.Drawing.Color.GreenYellow;
            this.Wokrview.IconChar = FontAwesome.Sharp.IconChar.Industry;
            this.Wokrview.IconColor = System.Drawing.Color.GreenYellow;
            this.Wokrview.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Wokrview.IconSize = 32;
            this.Wokrview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Wokrview.Location = new System.Drawing.Point(-5, -21);
            this.Wokrview.Name = "Wokrview";
            this.Wokrview.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Wokrview.Size = new System.Drawing.Size(254, 84);
            this.Wokrview.TabIndex = 4;
            this.Wokrview.Text = "           생산";
            this.Wokrview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Wokrview.UseVisualStyleBackColor = false;
            this.Wokrview.Click += new System.EventHandler(this.menu_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Workmain);
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 45);
            this.panel2.TabIndex = 5;
            // 
            // Workmain
            // 
            this.Workmain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.Workmain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Workmain.ForeColor = System.Drawing.Color.White;
            this.Workmain.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.Workmain.IconColor = System.Drawing.Color.White;
            this.Workmain.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Workmain.IconSize = 25;
            this.Workmain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Workmain.Location = new System.Drawing.Point(-4, -19);
            this.Workmain.Name = "Workmain";
            this.Workmain.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Workmain.Size = new System.Drawing.Size(253, 84);
            this.Workmain.TabIndex = 4;
            this.Workmain.Text = "           생산 메인";
            this.Workmain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Workmain.UseVisualStyleBackColor = false;
            this.Workmain.Click += new System.EventHandler(this.Workmain_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.Inventory);
            this.panel7.Location = new System.Drawing.Point(0, 90);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(233, 45);
            this.panel7.TabIndex = 4;
            // 
            // Inventory
            // 
            this.Inventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.Inventory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inventory.ForeColor = System.Drawing.Color.White;
            this.Inventory.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.Inventory.IconColor = System.Drawing.Color.White;
            this.Inventory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Inventory.IconSize = 25;
            this.Inventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Inventory.Location = new System.Drawing.Point(-4, -19);
            this.Inventory.Name = "Inventory";
            this.Inventory.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Inventory.Size = new System.Drawing.Size(253, 84);
            this.Inventory.TabIndex = 4;
            this.Inventory.Text = "           베스/약품 관리";
            this.Inventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Inventory.UseVisualStyleBackColor = false;
            this.Inventory.Click += new System.EventHandler(this.Inventory_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.Plan);
            this.panel6.Location = new System.Drawing.Point(0, 135);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(233, 45);
            this.panel6.TabIndex = 3;
            // 
            // Plan
            // 
            this.Plan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.Plan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plan.ForeColor = System.Drawing.Color.White;
            this.Plan.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.Plan.IconColor = System.Drawing.Color.White;
            this.Plan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Plan.IconSize = 25;
            this.Plan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Plan.Location = new System.Drawing.Point(-4, -19);
            this.Plan.Name = "Plan";
            this.Plan.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Plan.Size = new System.Drawing.Size(253, 84);
            this.Plan.TabIndex = 4;
            this.Plan.Text = "           생산 계획";
            this.Plan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Plan.UseVisualStyleBackColor = false;
            this.Plan.Click += new System.EventHandler(this.Plan_Click);
            // 
            // pnOut
            // 
            this.pnOut.Controls.Add(this.Output);
            this.pnOut.Location = new System.Drawing.Point(3, 231);
            this.pnOut.Name = "pnOut";
            this.pnOut.Size = new System.Drawing.Size(233, 45);
            this.pnOut.TabIndex = 5;
            // 
            // Output
            // 
            this.Output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.Output.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.ForeColor = System.Drawing.Color.GreenYellow;
            this.Output.IconChar = FontAwesome.Sharp.IconChar.BoxesAlt;
            this.Output.IconColor = System.Drawing.Color.GreenYellow;
            this.Output.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Output.IconSize = 32;
            this.Output.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Output.Location = new System.Drawing.Point(-4, -19);
            this.Output.Name = "Output";
            this.Output.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Output.Size = new System.Drawing.Size(253, 84);
            this.Output.TabIndex = 4;
            this.Output.Text = "           출고";
            this.Output.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Output.UseVisualStyleBackColor = false;
            this.Output.Click += new System.EventHandler(this.Output_Click);
            // 
            // pnChart
            // 
            this.pnChart.Controls.Add(this.Chart);
            this.pnChart.Location = new System.Drawing.Point(3, 282);
            this.pnChart.Name = "pnChart";
            this.pnChart.Size = new System.Drawing.Size(233, 45);
            this.pnChart.TabIndex = 6;
            // 
            // Chart
            // 
            this.Chart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.Chart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chart.ForeColor = System.Drawing.Color.GreenYellow;
            this.Chart.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.Chart.IconColor = System.Drawing.Color.GreenYellow;
            this.Chart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Chart.IconSize = 32;
            this.Chart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Chart.Location = new System.Drawing.Point(-4, -19);
            this.Chart.Name = "Chart";
            this.Chart.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Chart.Size = new System.Drawing.Size(253, 84);
            this.Chart.TabIndex = 4;
            this.Chart.Text = "           통계";
            this.Chart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Chart.UseVisualStyleBackColor = false;
            this.Chart.Click += new System.EventHandler(this.Chart_Click);
            // 
            // pnSystem
            // 
            this.pnSystem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.pnSystem.Controls.Add(this.panel10);
            this.pnSystem.Controls.Add(this.panel5);
            this.pnSystem.Controls.Add(this.panel9);
            this.pnSystem.Controls.Add(this.panel8);
            this.pnSystem.Controls.Add(this.panel11);
            this.pnSystem.Location = new System.Drawing.Point(0, 330);
            this.pnSystem.Margin = new System.Windows.Forms.Padding(0);
            this.pnSystem.Name = "pnSystem";
            this.pnSystem.Size = new System.Drawing.Size(233, 45);
            this.pnSystem.TabIndex = 6;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.Systemmain);
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Margin = new System.Windows.Forms.Padding(0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(233, 45);
            this.panel10.TabIndex = 7;
            // 
            // Systemmain
            // 
            this.Systemmain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.Systemmain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Systemmain.ForeColor = System.Drawing.Color.GreenYellow;
            this.Systemmain.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.Systemmain.IconColor = System.Drawing.Color.GreenYellow;
            this.Systemmain.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Systemmain.IconSize = 32;
            this.Systemmain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Systemmain.Location = new System.Drawing.Point(-4, -17);
            this.Systemmain.Name = "Systemmain";
            this.Systemmain.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.Systemmain.Size = new System.Drawing.Size(253, 84);
            this.Systemmain.TabIndex = 4;
            this.Systemmain.Text = "           관리";
            this.Systemmain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Systemmain.UseVisualStyleBackColor = false;
            this.Systemmain.Click += new System.EventHandler(this.Systemmain_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.System1);
            this.panel5.Location = new System.Drawing.Point(0, 45);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(233, 45);
            this.panel5.TabIndex = 5;
            // 
            // System1
            // 
            this.System1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.System1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.System1.ForeColor = System.Drawing.Color.White;
            this.System1.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.System1.IconColor = System.Drawing.Color.White;
            this.System1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.System1.IconSize = 25;
            this.System1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.System1.Location = new System.Drawing.Point(-4, -19);
            this.System1.Name = "System1";
            this.System1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.System1.Size = new System.Drawing.Size(253, 84);
            this.System1.TabIndex = 4;
            this.System1.Text = "           발주서 등록";
            this.System1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.System1.UseVisualStyleBackColor = false;
            this.System1.Click += new System.EventHandler(this.System1_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.System2);
            this.panel9.Location = new System.Drawing.Point(0, 90);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(233, 45);
            this.panel9.TabIndex = 4;
            // 
            // System2
            // 
            this.System2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.System2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.System2.ForeColor = System.Drawing.Color.White;
            this.System2.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.System2.IconColor = System.Drawing.Color.White;
            this.System2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.System2.IconSize = 25;
            this.System2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.System2.Location = new System.Drawing.Point(-4, -19);
            this.System2.Name = "System2";
            this.System2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.System2.Size = new System.Drawing.Size(253, 84);
            this.System2.TabIndex = 4;
            this.System2.Text = "           품목 등록";
            this.System2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.System2.UseVisualStyleBackColor = false;
            this.System2.Click += new System.EventHandler(this.System2_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel4);
            this.panel8.Controls.Add(this.System3);
            this.panel8.Location = new System.Drawing.Point(0, 135);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(233, 45);
            this.panel8.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.iconButton5);
            this.panel4.Location = new System.Drawing.Point(0, 35);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(233, 45);
            this.panel4.TabIndex = 8;
            // 
            // iconButton5
            // 
            this.iconButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.iconButton5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton5.ForeColor = System.Drawing.Color.White;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.iconButton5.IconColor = System.Drawing.Color.White;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 25;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(-4, -17);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.iconButton5.Size = new System.Drawing.Size(253, 84);
            this.iconButton5.TabIndex = 4;
            this.iconButton5.Text = "           시스템 관리";
            this.iconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.UseVisualStyleBackColor = false;
            // 
            // System3
            // 
            this.System3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.System3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.System3.ForeColor = System.Drawing.Color.White;
            this.System3.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.System3.IconColor = System.Drawing.Color.White;
            this.System3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.System3.IconSize = 25;
            this.System3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.System3.Location = new System.Drawing.Point(-4, -19);
            this.System3.Name = "System3";
            this.System3.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.System3.Size = new System.Drawing.Size(253, 84);
            this.System3.TabIndex = 4;
            this.System3.Text = "           레시피 등록";
            this.System3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.System3.UseVisualStyleBackColor = false;
            this.System3.Click += new System.EventHandler(this.System3_Click);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Controls.Add(this.System4);
            this.panel11.Location = new System.Drawing.Point(0, 180);
            this.panel11.Margin = new System.Windows.Forms.Padding(0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(233, 45);
            this.panel11.TabIndex = 9;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.iconButton1);
            this.panel12.Location = new System.Drawing.Point(0, 35);
            this.panel12.Margin = new System.Windows.Forms.Padding(0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(233, 45);
            this.panel12.TabIndex = 8;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(-4, -17);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.iconButton1.Size = new System.Drawing.Size(253, 84);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.Text = "           시스템 관리";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // System4
            // 
            this.System4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.System4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.System4.ForeColor = System.Drawing.Color.White;
            this.System4.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.System4.IconColor = System.Drawing.Color.White;
            this.System4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.System4.IconSize = 25;
            this.System4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.System4.Location = new System.Drawing.Point(-4, -19);
            this.System4.Name = "System4";
            this.System4.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.System4.Size = new System.Drawing.Size(253, 84);
            this.System4.TabIndex = 4;
            this.System4.Text = "           시스템 관리";
            this.System4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.System4.UseVisualStyleBackColor = false;
            this.System4.Click += new System.EventHandler(this.System4_Click);
            // 
            // menuTransition
            // 
            this.menuTransition.Interval = 10;
            this.menuTransition.Tick += new System.EventHandler(this.menuTransition_Tick);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // menuTransition2
            // 
            this.menuTransition2.Interval = 10;
            this.menuTransition2.Tick += new System.EventHandler(this.menuTransition2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1500, 800);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.sidebar.ResumeLayout(false);
            this.pnMain.ResumeLayout(false);
            this.pnIn.ResumeLayout(false);
            this.pnQC.ResumeLayout(false);
            this.menuContainer.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.pnOut.ResumeLayout(false);
            this.pnChart.ResumeLayout(false);
            this.pnSystem.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel pnMain;
        private FontAwesome.Sharp.IconButton Main;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton Wokrview;
        private System.Windows.Forms.Panel pnIn;
        private FontAwesome.Sharp.IconButton Input;
        private System.Windows.Forms.Panel pnQC;
        private FontAwesome.Sharp.IconButton Qc;
        private System.Windows.Forms.FlowLayoutPanel menuContainer;
        private System.Windows.Forms.Panel panel6;
        private FontAwesome.Sharp.IconButton Plan;
        private System.Windows.Forms.Panel panel7;
        private FontAwesome.Sharp.IconButton Inventory;
        private System.Windows.Forms.Panel pnOut;
        private FontAwesome.Sharp.IconButton Output;
        private System.Windows.Forms.Panel pnChart;
        private FontAwesome.Sharp.IconButton Chart;
        private FontAwesome.Sharp.IconButton Systemmain;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer sidebarTransition;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton Workmain;
        private System.Windows.Forms.FlowLayoutPanel pnSystem;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton System1;
        private System.Windows.Forms.Panel panel9;
        private FontAwesome.Sharp.IconButton System2;
        private System.Windows.Forms.Panel panel8;
        private FontAwesome.Sharp.IconButton System3;
        private System.Windows.Forms.Panel panel10;
        private FontAwesome.Sharp.IconButton iconButton5;
        private System.Windows.Forms.Timer menuTransition2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton System4;
    }
}
