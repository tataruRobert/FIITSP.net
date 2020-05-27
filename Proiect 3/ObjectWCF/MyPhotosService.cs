using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace MyPhotosObjectWCF
{
    public class MyPhotosImpl : IPhotos, ILocation, IPerson, IFeature
    {
        Api photosApi = new PhotosApi();

        public List<Photos> GetPhotos()
        {
            return photosApi.GetPhotos();;
        }

        public List<string> GetPhotoPaths()
        {
            return photosApi.getPhoyoPath();
        }


        public bool AddNewPhoto(string path, DateTime date, string Location, List<string> personNames)
        {
            return photosApi.AddNewPhoto(path, date, Location, personNames);
        }

        public DateTime GetDateTimeByPath(string path)
        {
            return photosApi.GetDateTimeByPath(path);
        }

        public int GetPhotoIdByPath(string path)
        {
            return photosApi.GetPhotoIdByPath(path);
        }

        public void RemoveBtPath(string path)
        {
            return photosApi.RemoveBtPath(path);
        }

        public string GetLocationByPath(string path)
        {
            return photosApi.GetLocationByPath(path);
        }

        public List<string> GetPeopleByPath(string path)
        {
            return photosApi.GetPeopleByPath(path);
        }

        public void AddPersons(List<string> personNames, int photoId)
        {
            return photosApi.AddPersons(personNames, photoId);
        }

        public List<Tuple<string, string>> GetFeaturesByPath(string path)
        {
            return photosApi.GetFeaturesByPath(path);
        }

        public void AddFeature(List<Tuple<string, string>> newFeatures, int photoId)
        {
            return photosApi.AddFeatur(newFeatures, photoId);
        }
    }
}
