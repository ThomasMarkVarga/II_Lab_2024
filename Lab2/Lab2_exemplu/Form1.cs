using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_exemplu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Un MessageBox", "Primul MessageBox");
        }

        private void myButton_Click(object sender, EventArgs e)
        {
            // toate se intampla la apasarea butonului
            string textString; //variabila in care copiem textul din primul lable
            textString = textBox1.Text; //luam textul din primul box si il memoram in variabila
            textBox2.Text = textString; //punem textul in al doilea box
        }

        private void nextFormBtn_Click(object sender, EventArgs e)
        {
            Form2 secondForm = new Form2();
            secondForm.Show(); //afiseaza noul form
        }

        private void fisiereBtn_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter = new StreamWriter("fisier.txt", true);
            streamWriter.WriteLine("limbaj de programare");
            streamWriter.Close();

            StreamReader streamReader = new StreamReader(path: "fisier.txt");
            {
                string line = string.Empty;
                while((line = streamReader.ReadLine()) != null)
                {
                    string[] tempArray = line.Split(' ');
                    textBox3.Text = tempArray[0];
                    textBox4.Text = tempArray[1];
                    textBox5.Text = tempArray[2];
                }
            }
        }
    }
}
