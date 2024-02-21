
namespace SuJinChemicalMES
{
    partial class formSystem4Okay
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.UserPW_tb = new System.Windows.Forms.TextBox();
            this.UserRegistration_lb = new System.Windows.Forms.Label();
            this.RegiUserList_lb = new System.Windows.Forms.Label();
            this.UserRegistration_bt = new System.Windows.Forms.Button();
            this.UserRank_tb = new System.Windows.Forms.TextBox();
            this.UserDepartment_tb = new System.Windows.Forms.TextBox();
            this.UserName_tb = new System.Windows.Forms.TextBox();
            this.RegiUserList_dgv = new System.Windows.Forms.DataGridView();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userdepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userrank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID_tb = new System.Windows.Forms.TextBox();
            this.UserRegistration_pn = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IDCheck_lb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RegiUserList_dgv)).BeginInit();
            this.UserRegistration_pn.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserPW_tb
            // 
            this.UserPW_tb.Location = new System.Drawing.Point(601, 14);
            this.UserPW_tb.Name = "UserPW_tb";
            this.UserPW_tb.Size = new System.Drawing.Size(120, 23);
            this.UserPW_tb.TabIndex = 15;
            // 
            // UserRegistration_lb
            // 
            this.UserRegistration_lb.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.UserRegistration_lb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.UserRegistration_lb.Location = new System.Drawing.Point(12, 43);
            this.UserRegistration_lb.Name = "UserRegistration_lb";
            this.UserRegistration_lb.Size = new System.Drawing.Size(1011, 24);
            this.UserRegistration_lb.TabIndex = 20;
            this.UserRegistration_lb.Text = "사용자 등록";
            this.UserRegistration_lb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RegiUserList_lb
            // 
            this.RegiUserList_lb.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.RegiUserList_lb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.RegiUserList_lb.Location = new System.Drawing.Point(12, 158);
            this.RegiUserList_lb.Name = "RegiUserList_lb";
            this.RegiUserList_lb.Size = new System.Drawing.Size(1011, 24);
            this.RegiUserList_lb.TabIndex = 19;
            this.RegiUserList_lb.Text = "사용자 목록";
            this.RegiUserList_lb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserRegistration_bt
            // 
            this.UserRegistration_bt.BackColor = System.Drawing.Color.White;
            this.UserRegistration_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserRegistration_bt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserRegistration_bt.Location = new System.Drawing.Point(901, 23);
            this.UserRegistration_bt.Name = "UserRegistration_bt";
            this.UserRegistration_bt.Size = new System.Drawing.Size(93, 38);
            this.UserRegistration_bt.TabIndex = 20;
            this.UserRegistration_bt.Text = "등록";
            this.UserRegistration_bt.UseVisualStyleBackColor = false;
            this.UserRegistration_bt.Click += new System.EventHandler(this.UserRegistration_bt_Click);
            // 
            // UserRank_tb
            // 
            this.UserRank_tb.Location = new System.Drawing.Point(360, 51);
            this.UserRank_tb.Name = "UserRank_tb";
            this.UserRank_tb.Size = new System.Drawing.Size(120, 23);
            this.UserRank_tb.TabIndex = 19;
            // 
            // UserDepartment_tb
            // 
            this.UserDepartment_tb.Location = new System.Drawing.Point(117, 51);
            this.UserDepartment_tb.Name = "UserDepartment_tb";
            this.UserDepartment_tb.Size = new System.Drawing.Size(120, 23);
            this.UserDepartment_tb.TabIndex = 18;
            // 
            // UserName_tb
            // 
            this.UserName_tb.Location = new System.Drawing.Point(117, 14);
            this.UserName_tb.Name = "UserName_tb";
            this.UserName_tb.Size = new System.Drawing.Size(120, 23);
            this.UserName_tb.TabIndex = 13;
            // 
            // RegiUserList_dgv
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RegiUserList_dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.RegiUserList_dgv.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.RegiUserList_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RegiUserList_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.username,
            this.userID,
            this.userPW,
            this.userdepartment,
            this.userrank});
            this.RegiUserList_dgv.Location = new System.Drawing.Point(12, 181);
            this.RegiUserList_dgv.Name = "RegiUserList_dgv";
            this.RegiUserList_dgv.RowHeadersWidth = 51;
            this.RegiUserList_dgv.RowTemplate.Height = 27;
            this.RegiUserList_dgv.Size = new System.Drawing.Size(1011, 339);
            this.RegiUserList_dgv.TabIndex = 18;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "이름";
            this.username.MinimumWidth = 6;
            this.username.Name = "username";
            this.username.Width = 125;
            // 
            // userID
            // 
            this.userID.DataPropertyName = "userID";
            this.userID.HeaderText = "ID";
            this.userID.MinimumWidth = 6;
            this.userID.Name = "userID";
            this.userID.Width = 125;
            // 
            // userPW
            // 
            this.userPW.DataPropertyName = "userPW";
            this.userPW.HeaderText = "PW";
            this.userPW.MinimumWidth = 6;
            this.userPW.Name = "userPW";
            this.userPW.Width = 125;
            // 
            // userdepartment
            // 
            this.userdepartment.DataPropertyName = "userdepartment";
            this.userdepartment.HeaderText = "부서";
            this.userdepartment.MinimumWidth = 6;
            this.userdepartment.Name = "userdepartment";
            this.userdepartment.Width = 125;
            // 
            // userrank
            // 
            this.userrank.DataPropertyName = "userrank";
            this.userrank.HeaderText = "직급";
            this.userrank.MinimumWidth = 6;
            this.userrank.Name = "userrank";
            this.userrank.Width = 125;
            // 
            // UserID_tb
            // 
            this.UserID_tb.Location = new System.Drawing.Point(360, 14);
            this.UserID_tb.Name = "UserID_tb";
            this.UserID_tb.Size = new System.Drawing.Size(120, 23);
            this.UserID_tb.TabIndex = 14;
            // 
            // UserRegistration_pn
            // 
            this.UserRegistration_pn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.UserRegistration_pn.Controls.Add(this.label5);
            this.UserRegistration_pn.Controls.Add(this.label3);
            this.UserRegistration_pn.Controls.Add(this.label2);
            this.UserRegistration_pn.Controls.Add(this.label1);
            this.UserRegistration_pn.Controls.Add(this.label4);
            this.UserRegistration_pn.Controls.Add(this.IDCheck_lb);
            this.UserRegistration_pn.Controls.Add(this.UserRegistration_bt);
            this.UserRegistration_pn.Controls.Add(this.UserRank_tb);
            this.UserRegistration_pn.Controls.Add(this.UserDepartment_tb);
            this.UserRegistration_pn.Controls.Add(this.UserPW_tb);
            this.UserRegistration_pn.Controls.Add(this.UserID_tb);
            this.UserRegistration_pn.Controls.Add(this.UserName_tb);
            this.UserRegistration_pn.Location = new System.Drawing.Point(12, 64);
            this.UserRegistration_pn.Name = "UserRegistration_pn";
            this.UserRegistration_pn.Size = new System.Drawing.Size(1011, 82);
            this.UserRegistration_pn.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.LightCyan;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(496, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 22);
            this.label5.TabIndex = 51;
            this.label5.Text = "PW";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightCyan;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(255, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 22);
            this.label3.TabIndex = 50;
            this.label3.Text = "직급";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightCyan;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(255, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 22);
            this.label2.TabIndex = 49;
            this.label2.Text = "ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightCyan;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 22);
            this.label1.TabIndex = 48;
            this.label1.Text = "부서";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightCyan;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 22);
            this.label4.TabIndex = 47;
            this.label4.Text = "이름";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IDCheck_lb
            // 
            this.IDCheck_lb.AutoSize = true;
            this.IDCheck_lb.Location = new System.Drawing.Point(94, 131);
            this.IDCheck_lb.Name = "IDCheck_lb";
            this.IDCheck_lb.Size = new System.Drawing.Size(0, 15);
            this.IDCheck_lb.TabIndex = 21;
            // 
            // formSystem4Okay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1035, 530);
            this.Controls.Add(this.UserRegistration_lb);
            this.Controls.Add(this.RegiUserList_lb);
            this.Controls.Add(this.RegiUserList_dgv);
            this.Controls.Add(this.UserRegistration_pn);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "formSystem4Okay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "사용자 등록";
            this.Load += new System.EventHandler(this.formSystem4Okay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RegiUserList_dgv)).EndInit();
            this.UserRegistration_pn.ResumeLayout(false);
            this.UserRegistration_pn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox UserPW_tb;
        private System.Windows.Forms.Label UserRegistration_lb;
        private System.Windows.Forms.Label RegiUserList_lb;
        private System.Windows.Forms.Button UserRegistration_bt;
        private System.Windows.Forms.TextBox UserRank_tb;
        private System.Windows.Forms.TextBox UserDepartment_tb;
        private System.Windows.Forms.TextBox UserName_tb;
        private System.Windows.Forms.DataGridView RegiUserList_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn userID;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPW;
        private System.Windows.Forms.DataGridViewTextBoxColumn userdepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn userrank;
        private System.Windows.Forms.TextBox UserID_tb;
        private System.Windows.Forms.Panel UserRegistration_pn;
        private System.Windows.Forms.Label IDCheck_lb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}