using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect1_3
{
    class Api
    {
        private readonly Model1Container _modelContainer;

        public Api()
        {
            _modelContainer = new Model1Container();
        }

        public bool AddNewPhoto(string path, DateTime date, string Location, List<string> personNames)
        {
            if (!_modelContainer.Photos.Any(p => p.Path == path))
            {
                var photo = new Photos()
                {
                    Date = date,
                    Path = path,
                };

                _modelContainer.Photos.Add(photo);

                _modelContainer.SaveChanges();
                var photoId = GetPhotoIdByPath(path);
                var location = new Locations()
                {
                    Name = Location,
                    PhotosId = photoId
                };

                _modelContainer.Locations.Add(location);
                _modelContainer.SaveChanges();
                AddPersons(personNames, photoId);
                return true;
            }
            return false;

        }

        public DateTime GetDateTimeByPath(string path)
        {
            return _modelContainer.Photos.Where(p => p.Path == path).Select(p => p.Date).First();
        }

        public string GetLocationByPath(string path)
        {
            var locations = from location in _modelContainer.Locations
                            join photo in _modelContainer.Photos on location.PhotosId equals photo.Id
                            where photo.Path == path
                            select location;
            return locations.First().Name;
            
        }

        public List<Photos> GetPhotos()
        {
            return _modelContainer.Photos.ToList();
        }

        public List<string> GetPhotoPaths()
        {
            return _modelContainer.Photos.Select(p => p.Path).ToList();
        }

        public List<string> GetPeopleByPath(string path)
        {
            List<string> result = new List<string>();
            var persons = from peop in _modelContainer.People
                          join photo in _modelContainer.Photos on peop.PhotosId equals photo.Id
                          where photo.Path == path
                          select peop;
            foreach (var peop in persons)
            {
                result.Add(peop.Name);
            }
            return result;
        }

        public int GetPhotoIdByPath(string path)
        {
            return _modelContainer.Photos.Where(p => p.Path == path).Select(p => p.Id).First();
        }

        public void RemoveBtPath(string path)
        {
            var photoToDelete = _modelContainer.Photos.Where(p => p.Path == path).First();
            var people = from peop in _modelContainer.People
                             join photo in _modelContainer.Photos on peop.PhotosId equals photo.Id
                             where photo.Path == path
                             select peop;
            foreach (var peop in people)
            {
                _modelContainer.People.Remove(peop);
            }

            var locations = from location in _modelContainer.Locations
                         join photo in _modelContainer.Photos on location.PhotosId equals photo.Id
                         where photo.Path == path
                         select location;
            foreach (var location in locations)
            {
                _modelContainer.Locations.Remove(location);
            }
            var features = from feature in _modelContainer.Features
                            join photo in _modelContainer.Photos on feature.PhotosId equals photo.Id
                            where photo.Path == path
                            select feature;
            foreach (var feature in features)
            {
                _modelContainer.Features.Remove(feature);
            }
            _modelContainer.Photos.Remove(photoToDelete);
            _modelContainer.SaveChanges();
        }

        public void AddPersons(List<string> personNames, int photoId)
        {
            foreach (var name in personNames)
            {
                var personProperty = new People()
                {
                    Name = name,
                    PhotosId = photoId
                };

                _modelContainer.People.Add(personProperty);
                _modelContainer.SaveChanges();
            }
        }

        public void AddFeature(List<Tuple<string, string>> newFeatures, int photoId)
        {
            foreach (var tuple in newFeatures)
            {
                var propertyPair = new Features()
                {
                    Name = tuple.Item1,
                    Desc = tuple.Item2,
                    PhotosId = photoId
                };

                _modelContainer.Features.Add(propertyPair);
                _modelContainer.SaveChanges();
            }
        }

        public List<Tuple<string, string>> GetFeaturesByPath(string path)
        {
            var features = from feature in _modelContainer.Features
                             join photo in _modelContainer.Photos on feature.PhotosId equals photo.Id
                             where photo.Path == path
                             select new { feature.Name, feature.Desc };
            List<Tuple<string, string>> result = new List<Tuple<string, string>>();
            foreach (var feature in features)
            {
                Tuple<string, string> aux = new Tuple<string, string>(feature.Name, feature.Desc);
                result.Add(aux);
            }
            return result;
        }

        public List<string> returnSearhResults(DateTime? date, string location, string people)
        {
            HashSet<string> paths = new HashSet<string>();
           
            if (location != "")
            {
               
                var locations = from loc in _modelContainer.Locations
                                join photo in _modelContainer.Photos on loc.PhotosId equals photo.Id
                                where location == loc.Name
                                select photo.Path;
                foreach (var loc in locations)
                {
                    paths.Add(loc);
                }

            }
            if (people != "")
            {

                var persons = from peop in _modelContainer.People
                                join photo in _modelContainer.Photos on peop.PhotosId equals photo.Id
                                where people == peop.Name
                                select photo.Path;
                foreach (var peop in persons)
                {
                    paths.Add(peop);
                }

            }
            if (date is DateTime valueOfdate)
            {
                var photos = from photo in _modelContainer.Photos
                            where valueOfdate == photo.Date
                              select photo.Path;
                foreach (var photo in photos)
                {
                    paths.Add(photo);
                }
            }
            
            foreach (var el in paths)
            {
                Console.WriteLine(el);
            }
            List<string> result = paths.ToList(); 
            return result;
        }

    }
}
