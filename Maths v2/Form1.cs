using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maths_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int i1 = 3 * 4;
            int i2 = 12 / 4;
            int i3 = 15 / 4;
            int i4 = 15 % 4;
            int i5 = 2 + 3 * 4;
            int i6 = 2 + (3 * 4) / (2 - 4);
            double d1 = 3.1 * 2.3;
            double d2 = 1.0 / 3.0;
            double d3 = 1 / 3;

            richTextBox1.AppendText(i1 + "\n" + i2 + "\n" + i3 + "\n" + i4 + "\n" + i5 + "\n" + i6 + "\n");
            richTextBox1.AppendText(d1 + "\n" + d2 + "\n" + d3 + "\n");

            string st = "three";
            try
            {
                int it = int.Parse(st);
            }
            catch
            {
                MessageBox.Show(st + " is not an integer");
            }
            String s3 = "3.2";
            try
            {
                int i7 = int.Parse(s3); 
            }
            catch
            {
                MessageBox.Show(s3 = " is not an integer");
                int i7 = 0;
            }
            string s4 = "pi";
            try
            {
                double d4 = double.Parse(s4);
            }
            catch
            {
                double d4 = 0;
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
