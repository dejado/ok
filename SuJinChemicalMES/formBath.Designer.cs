namespace SuJinChemicalMES
{
    partial class formBath
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
            this.bath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bath
            // 
            this.bath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bath.Location = new System.Drawing.Point(0, 0);
            this.bath.Name = "bath";
            this.bath.Size = new System.Drawing.Size(633, 451);
            this.bath.TabIndex = 0;
            this.bath.Text = "label1";
            // 
            // formBath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 451);
            this.Controls.Add(this.bath);
            this.Name = "formBath";
            this.Text = "formBath";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label bath;
    }
}