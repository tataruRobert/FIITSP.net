using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using PhotoPropsService;

namespace Proiect3.Pages
{
    public class IndexModel : PageModel
    {

        public string SelectedFeature;

        private PhotosAndFesatuesClient client;
        public Photos[] photos;
        public Fesatues[] Fesatues;
        public List<string> photoPaths;
        public List<string> FeatureNames;

        public void OnGet()
        {
            PhotosAndFesatuesClient client = new PhotosAndFesatuesClient(new PhotosAndFesatuesClient.EndpointConfiguration());

            Fesatues = client.GetFesatuesAsync().Result;
            FeatureNames = new List<string>(Fesatues.Length);

            photos = client.GetPhotosAsync().Result;
            
            GetImagesWebPaths();

            GetFeatureNames();


        }

        public void OnPost(string selectedProp)
        {

            SelectedFeature = selectedProp;
            
            client = new PhotosAndFesatuesClient(new PhotosAndFesatuesClient.EndpointConfiguration());

            photos = client.GetPhotosByFeaturesNameAsync(selectedProp).Result;

            GetImagesWebPaths();

            Fesatues = client.GetFesatuesAsync().Result;
            featureNames = new List<string>(Fesatues.Length);

            GetFeatureNames();

        }

        public void GetFeatureNames() 
        {
            
            foreach (var feature in Fesatues)
            {
                if (!FeatureNames.Contains(Feature.Feature_name))
                {
                    FeatureNames.Add(Feature.Feature_name);
                }
            }
            FeatureNames = FeatureNames.OrderBy(name => name).ToList();
        }
        public void GetImagesWebPaths()
        {
            photoPaths = new List<string>(photos.Length);

            foreach (var photo in photos)
            {
                photoPaths.Add("http://127.0.0.1:8887/" + Path.GetFileName(photo.Path));
            }
        }
    }
}
