using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            result.Text = (float.Parse(firstNumber.Text) + float.Parse(secondNumber.Text)).ToString();
        }

        private void substractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            result.Text = (float.Parse(firstNumber.Text) - float.Parse(secondNumber.Text)).ToString();
        }

        private void multiplyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            result.Text = (float.Parse(firstNumber.Text) * float.Parse(secondNumber.Text)).ToString();
        }

        private void divideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            result.Text = (float.Parse(firstNumber.Text) / float.Parse(secondNumber.Text)).ToString();
        }
    }
}
