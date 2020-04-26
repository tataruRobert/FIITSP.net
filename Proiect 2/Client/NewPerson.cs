using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect1_3
{
    public partial class NewPerson : Form
    {
        public NewPerson()
        {
            InitializeComponent();
        }

        public string GetPersonName()
        {
            return textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Warning!\n There should be no empty fields!");
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

    }
}
