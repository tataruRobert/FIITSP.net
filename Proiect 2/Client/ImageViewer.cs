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
    public partial class ImageViewer : Form
    {
        private int _imgCount;
        private readonly Api _api;

        public ImageViewer()
        {
            _imgCount = 0;
            InitializeComponent();
            _api = new Api();
            LoadPhotosOnStart();
        }

        private void browse_btn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter =
                @"Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" +
                @"All files (*.*)|*.*";
            openFileDialog1.Multiselect = true;
            openFileDialog1.Title = @"Select Photos";
            openFileDialog1.FileName = "";
            imageList1.ImageSize = new Size(50, 50);
            List<string> personNames = new List<string>();

            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                foreach (var path in openFileDialog1.FileNames)
                {
                    DateTime imgDateTime = new DateTime();
                    string location = System.String.Empty;

                    using (NewImage formImgPrompt = new NewImage(path))
                    {
                        if (formImgPrompt.ShowDialog() == DialogResult.OK)
                        {
                            imgDateTime = formImgPrompt.GetDate();
                            location = formImgPrompt.GetLocation();
                            personNames = formImgPrompt.GetPersons();
                        }
                    }
                    if (!_api.AddNewPhoto(path, imgDateTime, location, personNames))
                    {
                        MessageBox.Show(@"Photo path already in DB!");
                    }
                    else
                    {
                        /* var photoId = _api.GetPhotoIdByPath(path);
                         _api.AddLocation(location, photoId);*/
                        LoadPhoto(path);
                    }
                }
            }
        }

        public void LoadPhotosOnStart() // loads currently existing photos from db
        {

            var photoPaths = _api.GetPhotoPaths();
            imageList1.ImageSize = new Size(50, 50);
            if (photoPaths.Count > 0)
            {
                foreach (var path in photoPaths)
                {
                    LoadPhoto(path);
                }
            }
        }

        public void LoadPhoto(string path) // loads/appends photo into the listview
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                //Console.WriteLine(sender);
                var path = listView1.SelectedItems[0].Tag.ToString();
                var date = _api.GetDateTimeByPath(path);
                //var properties = _api.GetPropertiesByPath(path);
                var photoId = _api.GetPhotoIdByPath(path);
                var location = _api.GetLocationByPath(path);
                var people = _api.GetPeopleByPath(path);
                var features = _api.GetFeaturesByPath(path);
                //List<Tuple<string, string>> features = new List<Tuple<string, string>>();
                bool removed = false;
                using (SelectedImage form = new SelectedImage(path, date, location, people, features))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        var newFeatures = form.GetFeatureTuples();
                        _api.AddFeature(newFeatures, photoId);
                        removed = form.Removed();

                    }
                }

                if (removed)
                {
                    _api.RemoveBtPath(path);
                    RemoveListviewItms();
                    LoadPhotosOnStart();
                    listView1.SelectedItems.Clear();
                }
            }


        }

        private void RemoveListviewItms()
        {
            imageList1 = new ImageList();
            imageList1.ImageSize = new Size(50, 50);
            _imgCount = 0;  // works as index for the listview items
            foreach (ListViewItem item in listView1.Items)
            {
                listView1.Items.Remove(item);
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            RemoveListviewItms();
            LoadPhotosOnStart();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            List<string> paths = new List<string>();
            using (SearchImage form = new SearchImage())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    DateTime? date = form.getDate();
                    string location = form.getLocation();
                    string people = form.getPeople();
                    paths = _api.returnSearhResults(date, location, people);
                    Console.WriteLine(paths);
                   
                }
            }
            if (paths.Count == 0)
            {
                MessageBox.Show("No Results found");
            }
            else
            {
                Console.WriteLine("ceva");
                using (SeeSearchResults form1 = new SeeSearchResults(paths))
                {
                    if (form1.ShowDialog() == DialogResult.OK)
                    {

                    }
                }

            }
        }
    }
}
