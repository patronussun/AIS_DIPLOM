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
    public partial class HelloForm : Form
    {
        public HelloForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //вход

            Form_dashboard fm = new Form_dashboard();
            fm.Show();

        }

        private void HelloForm_Load(object sender, EventArgs e)
        {

        }
    }
}
