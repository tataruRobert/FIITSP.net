using System;
using System.Collections.Generic;
using System.ServiceModel;
using Model;

namespace MyPhotosObjectWCF
{
    [ServiceContract]
    public interface IPhotos
    {
        [OperationContract]
        List<Photos> GetPhotos();

        [OperationContract]
        List<string> GetPhotoPaths();

        [OperationContract]
        bool AddNewPhoto(string path, DateTime date, string Location, List<string> personNames);

        [OperationContract]
        DateTime GetDateTimeByPath(string path);

        [OperationContract]
        int GetPhotoIdByPath(string path);

        [OperationContract]
        void RemoveBtPath(string path);
       }

    [ServiceContract]
    public interface ILocation
    {
            
        [OperationContract]
        string GetLocationByPath(string path)

    }

    [ServiceContract]
    public interface IPerson
    {

        [OperationContract]
        List<string> GetPeopleByPath(string path);

        [OperationContract]
        void AddPersons(List<string> personNames, int photoId);
    }

        [ServiceContract]
    public interface IFeature
    {


        [OperationContract]
        List<Tuple<string, string>> GetFeaturesByPath(string path);

        [OperationContract]
        void AddFeature(List<Tuple<string, string>> newFeatures, int photoId);

    }

       
}
