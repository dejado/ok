
namespace SuJinChemicalMES
{
    partial class formMainOkay
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
            this.CalendarPick_tlpn = new System.Windows.Forms.TableLayoutPanel();
            this.CalendarPickList_lb = new System.Windows.Forms.Label();
            this.CalendarPick_tlpn.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalendarPick_tlpn
            // 
            this.CalendarPick_tlpn.ColumnCount = 1;
            this.CalendarPick_tlpn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CalendarPick_tlpn.Controls.Add(this.CalendarPickList_lb, 0, 0);
            this.CalendarPick_tlpn.Location = new System.Drawing.Point(2, 1);
            this.CalendarPick_tlpn.Name = "CalendarPick_tlpn";
            this.CalendarPick_tlpn.RowCount = 2;
            this.CalendarPick_tlpn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CalendarPick_tlpn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 684F));
            this.CalendarPick_tlpn.Size = new System.Drawing.Size(1241, 708);
            this.CalendarPick_tlpn.TabIndex = 1;
            // 
            // CalendarPickList_lb
            // 
            this.CalendarPickList_lb.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CalendarPickList_lb.Dock = System.Windows.Forms.DockStyle.Top;
            this.CalendarPickList_lb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalendarPickList_lb.Location = new System.Drawing.Point(3, 0);
            this.CalendarPickList_lb.Name = "CalendarPickList_lb";
            this.CalendarPickList_lb.Size = new System.Drawing.Size(1235, 23);
            this.CalendarPickList_lb.TabIndex = 0;
            this.CalendarPickList_lb.Text = "생산일정";
            // 
            // formMainOkay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 711);
            this.Controls.Add(this.CalendarPick_tlpn);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "formMainOkay";
            this.Text = "formMainOkay";
            this.Load += new System.EventHandler(this.formMainOkay_Load);
            this.CalendarPick_tlpn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel CalendarPick_tlpn;
        private System.Windows.Forms.Label CalendarPickList_lb;
    }
}