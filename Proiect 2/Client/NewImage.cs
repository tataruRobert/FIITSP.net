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
    public partial class NewImage : Form
    {
        List<string> personsNames;
        private int position = 150;

        public NewImage(string path)
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(path);
            //PhotoName.Text = path;
            photoLabel.Text = path;
            personsNames = new List<string>();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && personsNames.Count == 0)
            {
                MessageBox.Show("Warning!\n No empty fields!");
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        public DateTime GetDate()
        {
            return dateTimePicker1.Value;
        }

        public string GetLocation()
        {
            return textBox1.Text;
        }

        public List<string> GetPersons()
        {
            return personsNames;
        }

        private void people_add_Click(object sender, EventArgs e)
        {
            string personName = System.String.Empty;

            using (NewPerson form = new NewPerson())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    personName = form.GetPersonName();
                    personsNames.Add(personName);
                    AddPesonLabels(personName);
                }
            }
        }

        private void AddPesonLabels(string name)
        {
            Console.WriteLine(name);
            position += 20;
            Console.WriteLine(position);
            Label nameLabel = new Label();
            nameLabel.Text = "- " + name;
            nameLabel.Location = new Point(310, position);
            this.Controls.Add(nameLabel);
        }

       

        private void NewImage_Load(object sender, EventArgs e)
        {

        }
    }
}
