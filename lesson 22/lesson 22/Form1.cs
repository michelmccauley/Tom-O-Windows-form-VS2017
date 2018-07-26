using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson_22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = comboBox1.SelectedItem.ToString();
            if (item == "C++")
                MessageBox.Show("Rate: $45 per hour");
            else if (item == "Java")
                MessageBox.Show("Rate: $55 per hour");
            else 
                MessageBox.Show("Rate: $60 per hour");
        }
    }
}
