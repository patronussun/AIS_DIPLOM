using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIS_DIBLOM
{
    public partial class Form_dashboard : Form
    {
        public Form_dashboard()
        {
            InitializeComponent();
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Excel Files|*.xls";
                openFileDialog1.Title = "Select a Excel File";

                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    export_data.OpenSheet(openFileDialog1.FileName);

                    listView_dash.View = View.Tile;
                    listView_dash.Columns.Add("Сеансы");
                    listView_dash.Columns.Add("Посетители");
                    listView_dash.Columns.Add("Новые посетители");
                    listView_dash.Columns.Add("Среднее время сеанса");
                    listView_dash.Columns.Add("Просмотры страниц");
                    listView_dash.Columns.Add("Отказы");
                    listView_dash.Columns.Add("Достигнутых целей");
                    dataGridView1.DataSource = export_data.list;

                    for (int i = 0; i < export_data.list.Count; i++)
                    {
                        listView_dash.Items.Add("Сеансы");
                        listView_dash.Items.Add(export_data.list[i].Sessions);
                        listView_dash.Items.Add("Посетители");
                        listView_dash.Items.Add(export_data.list[i].Users);
                        listView_dash.Items.Add("Новые посетители");
                        listView_dash.Items.Add(export_data.list[i].NewUsers);
                        listView_dash.Items.Add("Среднее время сеанса");
                        listView_dash.Items.Add(Convert.ToString(export_data.list[i].Avg_session_length));
                        listView_dash.Items.Add("Просмотры страниц");
                        listView_dash.Items.Add(export_data.list[i].Pageviews);
                        listView_dash.Items.Add("Отказы");
                        listView_dash.Items.Add(export_data.list[i].Bounces);
                        listView_dash.Items.Add("Достигнутых целей");
                        listView_dash.Items.Add(export_data.list[i].TotalEvents);
                    }

                }
            }
            catch { MessageBox.Show("Ошибка при загрузке данных"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox_report.Text = "Было " + dataGridView1[1, 0].Value.ToString() + " сеанса(ов), сайт посетило "
                   + dataGridView1[2, 0].Value.ToString() + " уникальных посетителя(лей). На одного посетителя приходится " +
                  Convert.ToDouble(dataGridView1[1, 0].Value) / Convert.ToDouble(dataGridView1[2, 0].Value) + " сеанса(ов)."
                  + Environment.NewLine + Environment.NewLine + "Среди всех " + dataGridView1[3, 0].Value.ToString() + " новые. Это " +
                  Convert.ToInt32(dataGridView1[2, 0].Value) / Convert.ToInt32(dataGridView1[3, 0].Value) * 100 + "% от общего числа." +
                  Environment.NewLine + Environment.NewLine + " Средняя длина сеанса " + dataGridView1[4, 0].Value.ToString() + " минут(ы). " +
                  Environment.NewLine + Environment.NewLine + "Показатель отказов - " + dataGridView1[6, 0].Value.ToString() + ", т.е. " +
                  Convert.ToDouble(dataGridView1[6, 0].Value) / Convert.ToDouble(dataGridView1[1, 0].Value) * 100 +
                  "%. Для лендинга данный показатель должен стремиться к 100%." + Environment.NewLine + Environment.NewLine + "Количество достигнутых целей " +
                  dataGridView1[7, 0].Value.ToString() + ", т.к. на данном сайте не настроено отслеживание событий.";
                button_PDF.Enabled = true;
            }
            catch { MessageBox.Show("Ошибка при формировании отчета"); }

        }

        private void Form_dashboard_Load(object sender, EventArgs e)
        {
            button_PDF.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = new Form1();
            f.Show();
        }

        private void button_PDF_Click(object sender, EventArgs e)
        {

            ToPDF pdf = new ToPDF();
            //string[] headers = new[] { "Контрагент", "Задолженность" };

            string name = "";
            //var fileName = Guid.NewGuid() + ".png";
            //var bitmap = new Bitmap(500, 300);
            //pictureBox1.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, 500, 300));
            //bitmap.Save(fileName);
            //iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(fileName);
            //File.Delete(fileName);
            string report;
            report = Convert.ToString(richTextBox_report.Text);
            SaveFileDialog op = new SaveFileDialog();
            saveFileDialog1.Filter = "All files|*.pdf*";

            if (op.ShowDialog() == DialogResult.OK)
            {
                name = op.FileName;
                pdf.MakePdf(name, report);
            }
        }

    }
}
