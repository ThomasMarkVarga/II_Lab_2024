using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_4
{
    public partial class Form1 : Form
    {

        public string[] buttonsPressed = new string[2];

        public Form1()
        {
            InitializeComponent();
            Form1_Load();
        }

        public void Form1_Load()
        {
            string[] words = { "Audi", "Volkswagen", "Porsche" };
            foreach (string word in words)
            {
                listBox1.Items.Add(word);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (buttonsPressed[0] == null)
            {
                buttonsPressed[0] = radioButton1.Text;
            }
            else
            {
                buttonsPressed[1] = radioButton1.Text;
                string msg = buttonsPressed[0] + " " + buttonsPressed[1];
                MessageBox.Show(msg, "Message");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (buttonsPressed[0] == null)
            {
                buttonsPressed[0] = radioButton2.Text;
            }
            else
            {
                buttonsPressed[1] = radioButton2.Text;
                string msg = buttonsPressed[0] + " " + buttonsPressed[1];
                MessageBox.Show(msg, "Message");
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (buttonsPressed[0] == null)
            {
                buttonsPressed[0] = radioButton3.Text;
            }
            else
            {
                buttonsPressed[1] = radioButton3.Text;
                string msg = buttonsPressed[0] + " " + buttonsPressed[1];
                MessageBox.Show(msg, "Message");
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (buttonsPressed[0] == null)
            {
                buttonsPressed[0] = radioButton4.Text;
            }
            else
            {
                buttonsPressed[1] = radioButton4.Text;
                string msg = buttonsPressed[0] + " " + buttonsPressed[1];
                MessageBox.Show(msg, "Message");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string imageName = listBox1.SelectedItem.ToString() + ".jpg";
            pictureBox1.Image = new Bitmap(imageName);
        }
    }
}
