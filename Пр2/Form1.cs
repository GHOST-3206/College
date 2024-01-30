using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Пр2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string x = ""; 
        private void button1_Click(object sender, EventArgs e)
        {
            x = textBox1.Text;
            textBox1.Text = textBox2.Text;
            textBox2.Text = x;
        }
    }
}
