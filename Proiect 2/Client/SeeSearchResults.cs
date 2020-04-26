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

namespace proiect1_3
{
    public partial class SeeSearchResults : Form
    {
        private int _imgCount = 0;
        public SeeSearchResults(List<string> paths)
        {
            InitializeComponent();
            LoadPhotosOnStart(paths);
        }
        public void LoadPhotosOnStart(List<string> paths)
        {

            imageList1.ImageSize = new Size(50, 50);
            if (paths.Count > 0)
            {
                foreach (var path in paths)
                {
                    LoadPhoto(path);
                }
            }
        }

        public void LoadPhoto(string path) 
        {
            FileInfo fi = new FileInfo(path);
            using (FileStream stream = new FileStream(fi.FullName, FileMode.Open, FileAccess.Read))
            {
                imageList1.Images.Add(Image.FromStream(stream));
            }
            listView1.LargeImageList = imageList1;
            listView1.Items.Add(new ListViewItem
            {
                ImageIndex = _imgCount,
                Text = fi.Name,
                Tag = fi.FullName
            });
           _imgCount++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();

        }
    }
}
