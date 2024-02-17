namespace SuJinChemicalMES
{
    partial class formProductAsk
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
            this.Choose_bt = new System.Windows.Forms.Button();
            this.Ask_bt = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // Choose_bt
            // 
            this.Choose_bt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Choose_bt.Location = new System.Drawing.Point(315, 5);
            this.Choose_bt.Margin = new System.Windows.Forms.Padding(2);
            this.Choose_bt.Name = "Choose_bt";
            this.Choose_bt.Size = new System.Drawing.Size(71, 26);
            this.Choose_bt.TabIndex = 79;
            this.Choose_bt.Text = "선택";
            this.Choose_bt.UseVisualStyleBackColor = true;
            this.Choose_bt.Click += new System.EventHandler(this.Choose_bt_Click);
            // 
            // Ask_bt
            // 
            this.Ask_bt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Ask_bt.Location = new System.Drawing.Point(240, 5);
            this.Ask_bt.Margin = new System.Windows.Forms.Padding(2);
            this.Ask_bt.Name = "Ask_bt";
            this.Ask_bt.Size = new System.Drawing.Size(71, 26);
            this.Ask_bt.TabIndex = 78;
            this.Ask_bt.Text = "조회";
            this.Ask_bt.UseVisualStyleBackColor = true;
            this.Ask_bt.Click += new System.EventHandler(this.Ask_Click);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox4.Location = new System.Drawing.Point(101, 9);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(94, 27);
            this.textBox4.TabIndex = 76;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.LightCyan;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(8, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 22);
            this.label14.TabIndex = 77;
            this.label14.Text = "제품명";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1});
            this.dataGridView2.Location = new System.Drawing.Point(7, 35);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 10;
            this.dataGridView2.RowTemplate.Height = 30;
            this.dataGridView2.Size = new System.Drawing.Size(391, 513);
            this.dataGridView2.TabIndex = 75;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "제품코드";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "제품명";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 250;
            // 
            // formProductAsk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 553);
            this.Controls.Add(this.Choose_bt);
            this.Controls.Add(this.Ask_bt);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dataGridView2);
            this.Name = "formProductAsk";
            this.Text = "제품검색";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Choose_bt;
        private System.Windows.Forms.Button Ask_bt;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}