
namespace SuJinChemicalMES
{
    partial class formInputOkay
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
            this.InputOk_grid = new System.Windows.Forms.DataGridView();
            this.inspect1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.step1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.company1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outputdate1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InputRe_pn = new System.Windows.Forms.Panel();
            this.Input_date = new System.Windows.Forms.DateTimePicker();
            this.button8 = new System.Windows.Forms.Button();
            this.InputPerson_txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.InputRe_bt = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.InputLocation_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.InputClose_bt = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.InputOk_grid)).BeginInit();
            this.InputRe_pn.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputOk_grid
            // 
            this.InputOk_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InputOk_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inspect1,
            this.step1,
            this.company1,
            this.code1,
            this.name1,
            this.num1,
            this.outputdate1});
            this.InputOk_grid.Location = new System.Drawing.Point(50, 92);
            this.InputOk_grid.Margin = new System.Windows.Forms.Padding(2);
            this.InputOk_grid.Name = "InputOk_grid";
            this.InputOk_grid.RowHeadersWidth = 62;
            this.InputOk_grid.RowTemplate.Height = 30;
            this.InputOk_grid.Size = new System.Drawing.Size(1039, 276);
            this.InputOk_grid.TabIndex = 22;
            this.InputOk_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InputOk_grid_CellContentClick);
            this.InputOk_grid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.InputOk_grid_CellMouseClick);
            // 
            // inspect1
            // 
            this.inspect1.HeaderText = "검사결과";
            this.inspect1.MinimumWidth = 8;
            this.inspect1.Name = "inspect1";
            this.inspect1.Width = 150;
            // 
            // step1
            // 
            this.step1.HeaderText = "진행상태";
            this.step1.MinimumWidth = 8;
            this.step1.Name = "step1";
            this.step1.Width = 150;
            // 
            // company1
            // 
            this.company1.HeaderText = "회사";
            this.company1.MinimumWidth = 8;
            this.company1.Name = "company1";
            this.company1.Width = 150;
            // 
            // code1
            // 
            this.code1.HeaderText = "품번";
            this.code1.MinimumWidth = 8;
            this.code1.Name = "code1";
            this.code1.Width = 150;
            // 
            // name1
            // 
            this.name1.HeaderText = "품명";
            this.name1.MinimumWidth = 8;
            this.name1.Name = "name1";
            this.name1.Width = 150;
            // 
            // num1
            // 
            this.num1.HeaderText = "수량";
            this.num1.MinimumWidth = 8;
            this.num1.Name = "num1";
            this.num1.Width = 150;
            // 
            // outputdate1
            // 
            this.outputdate1.HeaderText = "납기일";
            this.outputdate1.MinimumWidth = 8;
            this.outputdate1.Name = "outputdate1";
            this.outputdate1.Width = 150;
            // 
            // InputRe_pn
            // 
            this.InputRe_pn.Controls.Add(this.Input_date);
            this.InputRe_pn.Controls.Add(this.button8);
            this.InputRe_pn.Controls.Add(this.InputPerson_txt);
            this.InputRe_pn.Controls.Add(this.button1);
            this.InputRe_pn.Controls.Add(this.InputRe_bt);
            this.InputRe_pn.Controls.Add(this.button10);
            this.InputRe_pn.Controls.Add(this.InputLocation_txt);
            this.InputRe_pn.Controls.Add(this.label6);
            this.InputRe_pn.Controls.Add(this.label7);
            this.InputRe_pn.Controls.Add(this.label8);
            this.InputRe_pn.Location = new System.Drawing.Point(50, 375);
            this.InputRe_pn.Margin = new System.Windows.Forms.Padding(2);
            this.InputRe_pn.Name = "InputRe_pn";
            this.InputRe_pn.Size = new System.Drawing.Size(963, 128);
            this.InputRe_pn.TabIndex = 21;
            // 
            // Input_date
            // 
            this.Input_date.CalendarFont = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Input_date.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Input_date.Location = new System.Drawing.Point(158, 69);
            this.Input_date.Margin = new System.Windows.Forms.Padding(2);
            this.Input_date.Name = "Input_date";
            this.Input_date.Size = new System.Drawing.Size(355, 38);
            this.Input_date.TabIndex = 4;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button8.Location = new System.Drawing.Point(967, 14);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(97, 36);
            this.button8.TabIndex = 0;
            this.button8.Text = "삭제";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // InputPerson_txt
            // 
            this.InputPerson_txt.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.InputPerson_txt.Location = new System.Drawing.Point(123, 16);
            this.InputPerson_txt.Margin = new System.Windows.Forms.Padding(2);
            this.InputPerson_txt.Name = "InputPerson_txt";
            this.InputPerson_txt.Size = new System.Drawing.Size(149, 38);
            this.InputPerson_txt.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(718, 61);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "수정";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // InputRe_bt
            // 
            this.InputRe_bt.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.InputRe_bt.Location = new System.Drawing.Point(608, 61);
            this.InputRe_bt.Margin = new System.Windows.Forms.Padding(2);
            this.InputRe_bt.Name = "InputRe_bt";
            this.InputRe_bt.Size = new System.Drawing.Size(97, 52);
            this.InputRe_bt.TabIndex = 0;
            this.InputRe_bt.Text = "등록";
            this.InputRe_bt.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button10.Location = new System.Drawing.Point(566, 14);
            this.button10.Margin = new System.Windows.Forms.Padding(2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(95, 39);
            this.button10.TabIndex = 0;
            this.button10.Text = "검색";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // InputLocation_txt
            // 
            this.InputLocation_txt.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.InputLocation_txt.Location = new System.Drawing.Point(387, 12);
            this.InputLocation_txt.Margin = new System.Windows.Forms.Padding(2);
            this.InputLocation_txt.Name = "InputLocation_txt";
            this.InputLocation_txt.Size = new System.Drawing.Size(161, 38);
            this.InputLocation_txt.TabIndex = 2;
            this.InputLocation_txt.Text = "창고";
            this.InputLocation_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(16, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 41);
            this.label6.TabIndex = 1;
            this.label6.Text = "등록인";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(16, 68);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 41);
            this.label7.TabIndex = 1;
            this.label7.Text = "등록일";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(291, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 41);
            this.label8.TabIndex = 1;
            this.label8.Text = "위치";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InputClose_bt
            // 
            this.InputClose_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.InputClose_bt.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.InputClose_bt.Location = new System.Drawing.Point(894, 52);
            this.InputClose_bt.Margin = new System.Windows.Forms.Padding(2);
            this.InputClose_bt.Name = "InputClose_bt";
            this.InputClose_bt.Size = new System.Drawing.Size(111, 36);
            this.InputClose_bt.TabIndex = 19;
            this.InputClose_bt.Text = "닫기";
            this.InputClose_bt.UseVisualStyleBackColor = true;
            this.InputClose_bt.Click += new System.EventHandler(this.InputClose_bt_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button6.Location = new System.Drawing.Point(779, 51);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(111, 36);
            this.button6.TabIndex = 20;
            this.button6.Text = "저장";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // formInputOkay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 758);
            this.Controls.Add(this.InputOk_grid);
            this.Controls.Add(this.InputRe_pn);
            this.Controls.Add(this.InputClose_bt);
            this.Controls.Add(this.button6);
            this.Name = "formInputOkay";
            this.Text = "formInputOkay";
            ((System.ComponentModel.ISupportInitialize)(this.InputOk_grid)).EndInit();
            this.InputRe_pn.ResumeLayout(false);
            this.InputRe_pn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView InputOk_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspect1;
        private System.Windows.Forms.DataGridViewTextBoxColumn step1;
        private System.Windows.Forms.DataGridViewTextBoxColumn company1;
        private System.Windows.Forms.DataGridViewTextBoxColumn code1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name1;
        private System.Windows.Forms.DataGridViewTextBoxColumn num1;
        private System.Windows.Forms.DataGridViewTextBoxColumn outputdate1;
        private System.Windows.Forms.Panel InputRe_pn;
        private System.Windows.Forms.DateTimePicker Input_date;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox InputPerson_txt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button InputRe_bt;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox InputLocation_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button InputClose_bt;
        private System.Windows.Forms.Button button6;
    }
}