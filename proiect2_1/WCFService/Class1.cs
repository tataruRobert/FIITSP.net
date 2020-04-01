using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFService
{
    [ServiceContract]
    public interface IPhotos
        {
            [OperationContract]
            List<IPhotos> GetPhotosByPath(string path);

            [OperationContract]
            string[] GetLocationsNamesOf(string path);

            [OperationContract]
            string[] GetPeopleNamesOf(string path);

            [OperationContract]
            string[] GetCustomPropertiesNamesOf(string path);
        }

        [ServiceContract]
        public interface ILocation
        {
            
            [OperationContract]
            Location NewLocation(string name);

            [OperationContract]
            string[] GetLocationsNames();

            [OperationContract]
            List<Locations> GetLocationsByPath(string path);
        }

        [ServiceContract]
        public interface IPerson
        {
           
            [OperationContract]
            string[] GetPeopleNames();

            [OperationContract]
            List<Person> GetPeopleByPath(string[] path);
        }

        [ServiceContract]
        public interface IFeature
        {


            [OperationContract]
            string[] GetFeatureName(string path);

            [OperationContract]
            string[] GetFeatureDesc(string path);

        }

       
}
