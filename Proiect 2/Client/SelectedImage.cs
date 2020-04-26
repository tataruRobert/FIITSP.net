using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace proiect1_3
{
    public partial class SelectedImage : Form
    {
        private string _photoPath;
        private int position = 140;
        private int positionFeature = 40;
        private List<Tuple<string,string>> featureTuples;
        private bool remove;
       
        public SelectedImage()
        {
            InitializeComponent();
        }

        public SelectedImage(string path, DateTime Date, string Location, List<string> people, List<Tuple<string,string>> features)
        {
            InitializeComponent();
            LoadPeople(people);
            LoadFeatures(features);
            _photoPath = path;
            photoName.Text = path;
            pictureBox1.Image = new Bitmap(path);
            date.Text = Date.ToString();
            location.Text = Location;
            featureTuples = new List<Tuple<string, string>>();
            remove = false;


        }

        public List<Tuple<string, string>> GetFeatureTuples()
        {
            return featureTuples;
        }

        public bool Removed()
        {
            return remove;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void rmv_btn_Click(object sender, EventArgs e)
        {
            remove = true;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void open_Click(object sender, EventArgs e)
        {
            Process.Start(_photoPath);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void LoadPeople(List<string> people)
        {
            foreach (string el in people)
            {
                AddPropertiesLabels(el);
            }
        }
        
        private void AddPropertiesLabels(string el)
        {
            position += 20;
            Label nameLabel = new Label();
            nameLabel.Text = "- " + el;
            nameLabel.Location = new Point(355, position);
            this.Controls.Add(nameLabel);
        }

        private void LoadFeatures(List<Tuple<string, string>> features)
        {
            foreach (Tuple<string, string> el in features)
            {
                AddFeaturesLabels(el.Item1, el.Item2);
            }
        }

        private void AddFeaturesLabels(string el1, string el2)
        {
            Console.WriteLine(el1);
            Console.WriteLine(el2);
            positionFeature += 25;
            Label nameLabel = new Label();
            Label descLabel = new Label();
            nameLabel.Text = "Name:" + el1;
            descLabel.Text = "Desc:" + el2;
            nameLabel.Location = new Point(260, positionFeature);
            positionFeature += 25;
            descLabel.Location = new Point(260, positionFeature);
            this.Controls.Add(nameLabel);
            this.Controls.Add(descLabel);
        }

        private void add_feature_Click(object sender, EventArgs e)
        {
            string featureName = System.String.Empty;
            string featureDesc = System.String.Empty;

            using (NewFeature form = new NewFeature())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    featureName = form.GetFeatureName();
                    featureDesc = form.GetFeatureDesc();
                    /*Console.WriteLine(featureName);
                    Console.WriteLine(featureDesc);*/
                    AddFeaturesLabels(featureName, featureDesc);
                    featureTuples.Add(new Tuple<string, string>(featureName, featureDesc));
                }
            }
        }
    }
}
