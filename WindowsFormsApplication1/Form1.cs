using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Please Click the button!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1 = dateTimePicker1.Value.Date.ToString();
            string s2 = dateTimePicker2.Value.ToLongTimeString();

            label1.Text = s1 + ", " + s2;
        }
    }
}
