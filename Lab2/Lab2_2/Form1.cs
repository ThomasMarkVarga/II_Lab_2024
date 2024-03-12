using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Form1_Load();
        }

        public void Form1_Load()
        {
            StreamReader streamReader = new StreamReader(path: "cuvinte.txt");
            {
                string line = String.Empty;
                while ((line = streamReader.ReadLine()) != null)
                {
                    string[] words = line.Split(' ');

                    foreach (string word in words)
                    {
                        listBox1.Items.Add(word);
                    }
                }
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            string temp = listBox1.SelectedItem.ToString();
            listBox2.Items.Add(temp);
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
        }
    }
}
