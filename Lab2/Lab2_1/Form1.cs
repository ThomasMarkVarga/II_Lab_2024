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

namespace Lab2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StreamReader streamReader = new StreamReader(path: "credential.txt");
            {
                string line = string.Empty;
                while((line = streamReader.ReadLine()) != null)
                {
                    string[] cred = line.Split(' ');
                    userTextBox.Text = cred[0];
                    passTextBox.Text = cred[1];
                }
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Form2 secondForm = new Form2();
            secondForm.Show();
        }
    }
}
