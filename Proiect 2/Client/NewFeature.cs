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
    public partial class NewFeature : Form
    {
        private string featureName = System.String.Empty;
        private string featureDesc = System.String.Empty;
        public NewFeature()
        {
            InitializeComponent();
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Warning!\n No empty fields!");
            }
            else
            {
                featureName = textBox1.Text;
                featureDesc = textBox2.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        public string GetFeatureName()
        {
            return featureName;
        }

        public string GetFeatureDesc()
        {
            return featureDesc;
        }



    }
}
