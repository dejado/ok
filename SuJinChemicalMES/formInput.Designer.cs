
namespace SuJinChemicalMES
{
    partial class formInput
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.InWarehouse_com = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.Company_com = new System.Windows.Forms.ComboBox();
            this.InputAsk_bt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.InName_txt = new System.Windows.Forms.TextBox();
            this.InCode_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Input_grid = new System.Windows.Forms.DataGridView();
            this.Inprogress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Incompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Incode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inlot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inquantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Indate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inregistant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inlocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Re_bt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.InputOk_bt = new System.Windows.Forms.Button();
            this.InModify_bt = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Input_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.InWarehouse_com);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.Company_com);
            this.panel2.Controls.Add(this.InputAsk_bt);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.InName_txt);
            this.panel2.Controls.Add(this.InCode_txt);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(14, 83);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1479, 161);
            this.panel2.TabIndex = 22;
            // 
            // InWarehouse_com
            // 
            this.InWarehouse_com.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.InWarehouse_com.FormattingEnabled = true;
            this.InWarehouse_com.Items.AddRange(new object[] {
            "양품IA",
            "부자재IB",
            "반품"});
            this.InWarehouse_com.Location = new System.Drawing.Point(183, 94);
            this.InWarehouse_com.Margin = new System.Windows.Forms.Padding(2);
            this.InWarehouse_com.Name = "InWarehouse_com";
            this.InWarehouse_com.Size = new System.Drawing.Size(213, 48);
            this.InWarehouse_com.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(19, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 49);
            this.label3.TabIndex = 5;
            this.label3.Text = "창고위치";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker2.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker2.Location = new System.Drawing.Point(663, 14);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(443, 44);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // Company_com
            // 
            this.Company_com.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Company_com.FormattingEnabled = true;
            this.Company_com.Items.AddRange(new object[] {
            "가이드",
            "덕산약품",
            "디스크",
            "링",
            "벨자",
            "샤프트",
            "쉴드",
            "케미컬코리아",
            "튜브"});
            this.Company_com.Location = new System.Drawing.Point(139, 17);
            this.Company_com.Margin = new System.Windows.Forms.Padding(2);
            this.Company_com.Name = "Company_com";
            this.Company_com.Size = new System.Drawing.Size(298, 48);
            this.Company_com.TabIndex = 3;
            // 
            // InputAsk_bt
            // 
            this.InputAsk_bt.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.InputAsk_bt.Location = new System.Drawing.Point(1331, 17);
            this.InputAsk_bt.Margin = new System.Windows.Forms.Padding(2);
            this.InputAsk_bt.Name = "InputAsk_bt";
            this.InputAsk_bt.Size = new System.Drawing.Size(124, 115);
            this.InputAsk_bt.TabIndex = 0;
            this.InputAsk_bt.Text = "조회";
            this.InputAsk_bt.UseVisualStyleBackColor = true;
            this.InputAsk_bt.Click += new System.EventHandler(this.InputAsk_bt_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(19, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 49);
            this.label5.TabIndex = 1;
            this.label5.Text = "회사";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InName_txt
            // 
            this.InName_txt.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.InName_txt.Location = new System.Drawing.Point(971, 89);
            this.InName_txt.Margin = new System.Windows.Forms.Padding(2);
            this.InName_txt.Name = "InName_txt";
            this.InName_txt.Size = new System.Drawing.Size(338, 53);
            this.InName_txt.TabIndex = 2;
            this.InName_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InCode_txt
            // 
            this.InCode_txt.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.InCode_txt.Location = new System.Drawing.Point(578, 89);
            this.InCode_txt.Margin = new System.Windows.Forms.Padding(2);
            this.InCode_txt.Name = "InCode_txt";
            this.InCode_txt.Size = new System.Drawing.Size(232, 53);
            this.InCode_txt.TabIndex = 2;
            this.InCode_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(839, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "제품명";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(488, 13);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 49);
            this.label7.TabIndex = 1;
            this.label7.Text = "등록일";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(419, 93);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 49);
            this.label8.TabIndex = 1;
            this.label8.Text = "제품코드";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Input_grid
            // 
            this.Input_grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Input_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Input_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Input_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Inprogress,
            this.Incompany,
            this.Incode,
            this.Inname,
            this.Inlot,
            this.Inquantity,
            this.Indate,
            this.Inregistant,
            this.Inlocation});
            this.Input_grid.Location = new System.Drawing.Point(24, 322);
            this.Input_grid.Margin = new System.Windows.Forms.Padding(2);
            this.Input_grid.Name = "Input_grid";
            this.Input_grid.RowHeadersWidth = 62;
            this.Input_grid.RowTemplate.Height = 30;
            this.Input_grid.Size = new System.Drawing.Size(1348, 493);
            this.Input_grid.TabIndex = 23;
            // 
            // Inprogress
            // 
            this.Inprogress.HeaderText = "진행상태";
            this.Inprogress.MinimumWidth = 8;
            this.Inprogress.Name = "Inprogress";
            this.Inprogress.Width = 150;
            // 
            // Incompany
            // 
            this.Incompany.HeaderText = "회사명";
            this.Incompany.MinimumWidth = 8;
            this.Incompany.Name = "Incompany";
            this.Incompany.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Incompany.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Incompany.Width = 150;
            // 
            // Incode
            // 
            this.Incode.HeaderText = "제품코드";
            this.Incode.MinimumWidth = 8;
            this.Incode.Name = "Incode";
            this.Incode.Width = 150;
            // 
            // Inname
            // 
            this.Inname.HeaderText = "제품명";
            this.Inname.MinimumWidth = 8;
            this.Inname.Name = "Inname";
            this.Inname.Width = 150;
            // 
            // Inlot
            // 
            this.Inlot.HeaderText = "Lot No.";
            this.Inlot.MinimumWidth = 8;
            this.Inlot.Name = "Inlot";
            this.Inlot.Width = 150;
            // 
            // Inquantity
            // 
            this.Inquantity.HeaderText = "제품수량";
            this.Inquantity.MinimumWidth = 8;
            this.Inquantity.Name = "Inquantity";
            this.Inquantity.Width = 150;
            // 
            // Indate
            // 
            this.Indate.HeaderText = "등록일";
            this.Indate.MinimumWidth = 8;
            this.Indate.Name = "Indate";
            this.Indate.Width = 150;
            // 
            // Inregistant
            // 
            this.Inregistant.HeaderText = "등록자";
            this.Inregistant.MinimumWidth = 8;
            this.Inregistant.Name = "Inregistant";
            this.Inregistant.Width = 150;
            // 
            // Inlocation
            // 
            this.Inlocation.HeaderText = "입창고 위치";
            this.Inlocation.MinimumWidth = 8;
            this.Inlocation.Name = "Inlocation";
            this.Inlocation.Width = 150;
            // 
            // Re_bt
            // 
            this.Re_bt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Re_bt.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Re_bt.Location = new System.Drawing.Point(1191, 265);
            this.Re_bt.Margin = new System.Windows.Forms.Padding(2);
            this.Re_bt.Name = "Re_bt";
            this.Re_bt.Size = new System.Drawing.Size(181, 42);
            this.Re_bt.TabIndex = 25;
            this.Re_bt.Text = "새로고침";
            this.Re_bt.UseVisualStyleBackColor = true;
            this.Re_bt.Click += new System.EventHandler(this.Re_bt_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(33, 269);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 36);
            this.label2.TabIndex = 24;
            this.label2.Text = "자재현황";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InputOk_bt
            // 
            this.InputOk_bt.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.InputOk_bt.Location = new System.Drawing.Point(1092, 24);
            this.InputOk_bt.Margin = new System.Windows.Forms.Padding(2);
            this.InputOk_bt.Name = "InputOk_bt";
            this.InputOk_bt.Size = new System.Drawing.Size(262, 43);
            this.InputOk_bt.TabIndex = 26;
            this.InputOk_bt.Text = "수입검사등록";
            this.InputOk_bt.UseVisualStyleBackColor = true;
            this.InputOk_bt.Click += new System.EventHandler(this.InputOk_bt_Click);
            // 
            // InModify_bt
            // 
            this.InModify_bt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.InModify_bt.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.InModify_bt.Location = new System.Drawing.Point(1038, 265);
            this.InModify_bt.Margin = new System.Windows.Forms.Padding(2);
            this.InModify_bt.Name = "InModify_bt";
            this.InModify_bt.Size = new System.Drawing.Size(134, 42);
            this.InModify_bt.TabIndex = 25;
            this.InModify_bt.Text = "수정";
            this.InModify_bt.UseVisualStyleBackColor = true;
            this.InModify_bt.Click += new System.EventHandler(this.InModify_bt_Click);
            // 
            // formInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1579, 910);
            this.Controls.Add(this.InputOk_bt);
            this.Controls.Add(this.InModify_bt);
            this.Controls.Add(this.Re_bt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Input_grid);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formInput";
            this.Text = "formInput";
            this.Load += new System.EventHandler(this.formInput_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Input_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox Company_com;
        private System.Windows.Forms.Button InputAsk_bt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView Input_grid;
        private System.Windows.Forms.Button Re_bt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button InputOk_bt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inprogress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Incompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn Incode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inlot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inquantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Indate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inregistant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inlocation;
        private System.Windows.Forms.TextBox InCode_txt;
        private System.Windows.Forms.Button InModify_bt;
        private System.Windows.Forms.TextBox InName_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox InWarehouse_com;
        private System.Windows.Forms.Label label3;
    }
}