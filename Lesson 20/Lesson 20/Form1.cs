using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_20
{
    public partial class Form1 : Form
    {
        Label l = new Label();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Label l2 = new Label();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            l.AllowDrop = true;

        }
    }
}
