using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string input = textBox1.Text;
                double textCapture = double.Parse(input);
                string output = $"{Math.Round(Math.Pow(textCapture, 2), 3)}";
                MessageBox.Show(output, "Output", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Please Note: " , MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            

        }
    }
}
