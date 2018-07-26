using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson_23_if_else_w_Method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBackColor = Color.White;
            string searchFor = textBox1.Text.ToLower();
            string text = richTextBox1.Text.ToLower();
            if (text.Contains(searchFor))
            {
                int start = text.IndexOf(searchFor);
                richTextBox1.Select(start, searchFor.Length);
                richTextBox1.SelectionBackColor = Color.Yellow;
                textBox1.Clear();
                richTextBox1.Select();
            }
            else
            {
                MessageBox.Show($"Text {searchFor} not found");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
