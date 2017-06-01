namespace AIS_DIBLOM
{
    partial class Form_reports
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
            this.richTextBox_report = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBox_report
            // 
            this.richTextBox_report.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox_report.Enabled = false;
            this.richTextBox_report.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_report.Location = new System.Drawing.Point(12, 12);
            this.richTextBox_report.Name = "richTextBox_report";
            this.richTextBox_report.ReadOnly = true;
            this.richTextBox_report.Size = new System.Drawing.Size(326, 275);
            this.richTextBox_report.TabIndex = 0;
            this.richTextBox_report.Text = "";
            // 
            // Form_reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 303);
            this.Controls.Add(this.richTextBox_report);
            this.Name = "Form_reports";
            this.Text = "Отчеты АИС \"Аналитикс\"";
            this.Load += new System.EventHandler(this.Form_reports_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox richTextBox_report;

    }
}