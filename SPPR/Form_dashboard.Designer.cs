namespace AIS_DIBLOM
{
    partial class Form_dashboard
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.button_load = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button_PDF = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.listView_dash = new System.Windows.Forms.ListView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.richTextBox_report = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(128, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите файл для загрузки";
            // 
            // button_load
            // 
            this.button_load.AutoSize = true;
            this.button_load.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button_load.Location = new System.Drawing.Point(349, 12);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(133, 29);
            this.button_load.TabIndex = 2;
            this.button_load.Text = "Загрузить данные";
            this.toolTip1.SetToolTip(this.button_load, "в формате .xls");
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button1.Location = new System.Drawing.Point(12, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Сформировать отчет\r\n";
            this.toolTip1.SetToolTip(this.button1, "На основании текущих данных");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_PDF
            // 
            this.button_PDF.AutoSize = true;
            this.button_PDF.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button_PDF.Location = new System.Drawing.Point(328, 274);
            this.button_PDF.Name = "button_PDF";
            this.button_PDF.Size = new System.Drawing.Size(154, 29);
            this.button_PDF.TabIndex = 7;
            this.button_PDF.Text = "Сохранить PDF";
            this.toolTip1.SetToolTip(this.button_PDF, "Сохранить отчет");
            this.button_PDF.UseVisualStyleBackColor = true;
            this.button_PDF.Click += new System.EventHandler(this.button_PDF_Click);
            // 
            // button_back
            // 
            this.button_back.AutoSize = true;
            this.button_back.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button_back.Location = new System.Drawing.Point(12, 9);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(79, 29);
            this.button_back.TabIndex = 8;
            this.button_back.Text = "Назад";
            this.toolTip1.SetToolTip(this.button_back, "Вернуться в окно авторизации");
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView_dash
            // 
            this.listView_dash.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listView_dash.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_dash.Location = new System.Drawing.Point(12, 44);
            this.listView_dash.Name = "listView_dash";
            this.listView_dash.Scrollable = false;
            this.listView_dash.ShowItemToolTips = true;
            this.listView_dash.Size = new System.Drawing.Size(470, 224);
            this.listView_dash.TabIndex = 4;
            this.listView_dash.UseCompatibleStateImageBehavior = false;
            this.listView_dash.View = System.Windows.Forms.View.Tile;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 349);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(291, 64);
            this.dataGridView1.TabIndex = 5;
            // 
            // richTextBox_report
            // 
            this.richTextBox_report.Location = new System.Drawing.Point(12, 309);
            this.richTextBox_report.Name = "richTextBox_report";
            this.richTextBox_report.ReadOnly = true;
            this.richTextBox_report.Size = new System.Drawing.Size(470, 173);
            this.richTextBox_report.TabIndex = 6;
            this.richTextBox_report.Text = "";
            // 
            // Form_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 491);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_PDF);
            this.Controls.Add(this.richTextBox_report);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listView_dash);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_load);
            this.Controls.Add(this.label1);
            this.Name = "Form_dashboard";
            this.Text = "Дашборд АИС \"Аналитик\"";
            this.Load += new System.EventHandler(this.Form_dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView_dash;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox richTextBox_report;
        private System.Windows.Forms.Button button_PDF;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}