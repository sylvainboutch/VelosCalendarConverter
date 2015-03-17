namespace VelosCalendarConverter
{
    partial class VelosCalendarConverter
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
            this.ofdOpenXls = new System.Windows.Forms.OpenFileDialog();
            this.sfdSaveCsv = new System.Windows.Forms.SaveFileDialog();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtOuput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnGo.Location = new System.Drawing.Point(0, 239);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(284, 23);
            this.btnGo.TabIndex = 0;
            this.btnGo.Text = "Choose calendar";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtOuput
            // 
            this.txtOuput.AcceptsReturn = true;
            this.txtOuput.AcceptsTab = true;
            this.txtOuput.CausesValidation = false;
            this.txtOuput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOuput.Location = new System.Drawing.Point(0, 0);
            this.txtOuput.MaxLength = 2147483647;
            this.txtOuput.Multiline = true;
            this.txtOuput.Name = "txtOuput";
            this.txtOuput.ReadOnly = true;
            this.txtOuput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOuput.Size = new System.Drawing.Size(284, 239);
            this.txtOuput.TabIndex = 2;
            // 
            // VelosCalendarConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txtOuput);
            this.Controls.Add(this.btnGo);
            this.Name = "VelosCalendarConverter";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdOpenXls;
        private System.Windows.Forms.SaveFileDialog sfdSaveCsv;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtOuput;
    }
}

