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
    public partial class SearchImage : Form
    {
        DateTime? date = null;
        string location = System.String.Empty;
        string people = System.String.Empty;

        public SearchImage()
        {
            InitializeComponent();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
           
            if (textBox2.Text != "")
            {
                location = textBox2.Text;
                /*MessageBox.Show("Warning!\n There should be no empty fields!");*/
            }
            if (textBox1.Text != "")
            {
                people = textBox1.Text;
                /*MessageBox.Show("Warning!\n There should be no empty fields!");*/
            }
            if (dateTimePicker1.Checked)
            {
                date = dateTimePicker1.Value;
                //Console.WriteLine(date);
                /*MessageBox.Show("Warning!\n There should be no empty fields!");*/
            }
            DialogResult = DialogResult.OK;
            Close();

        }
        public DateTime? getDate()
        {
            return date;
        }

        public string getLocation()
        {
            return location;
        }

        public string getPeople()
        {
            return people;
        }
    }
}
