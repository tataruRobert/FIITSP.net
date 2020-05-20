﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReferenceWCF
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="File", Namespace="http://schemas.datacontract.org/2004/07/MyPhotos")]
    public partial class File : object
    {
        
        private System.DateTime CreatedAtField;
        
        private bool DeletedField;
        
        private System.Collections.Generic.List<ServiceReferenceWCF.FileProperty> FilePropertiesField;
        
        private System.Guid IdField;
        
        private string NameField;
        
        private string PathField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreatedAt
        {
            get
            {
                return this.CreatedAtField;
            }
            set
            {
                this.CreatedAtField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Deleted
        {
            get
            {
                return this.DeletedField;
            }
            set
            {
                this.DeletedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<ServiceReferenceWCF.FileProperty> FileProperties
        {
            get
            {
                return this.FilePropertiesField;
            }
            set
            {
                this.FilePropertiesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Path
        {
            get
            {
                return this.PathField;
            }
            set
            {
                this.PathField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FileProperty", Namespace="http://schemas.datacontract.org/2004/07/MyPhotos")]
    public partial class FileProperty : object
    {
        
        private ServiceReferenceWCF.File FileField;
        
        private System.Guid FileIdField;
        
        private System.Guid IdField;
        
        private ServiceReferenceWCF.Property PropertyField;
        
        private System.Guid PropertyIdField;
        
        private string ValueField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReferenceWCF.File File
        {
            get
            {
                return this.FileField;
            }
            set
            {
                this.FileField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid FileId
        {
            get
            {
                return this.FileIdField;
            }
            set
            {
                this.FileIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReferenceWCF.Property Property
        {
            get
            {
                return this.PropertyField;
            }
            set
            {
                this.PropertyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid PropertyId
        {
            get
            {
                return this.PropertyIdField;
            }
            set
            {
                this.PropertyIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Value
        {
            get
            {
                return this.ValueField;
            }
            set
            {
                this.ValueField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Property", Namespace="http://schemas.datacontract.org/2004/07/MyPhotos")]
    public partial class Property : object
    {
        
        private string DescriptionField;
        
        private System.Collections.Generic.List<ServiceReferenceWCF.FileProperty> FilePropertiesField;
        
        private System.Guid IdField;
        
        private bool IsBaseField;
        
        private string TitleField;
        
        private string TypeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<ServiceReferenceWCF.FileProperty> FileProperties
        {
            get
            {
                return this.FilePropertiesField;
            }
            set
            {
                this.FilePropertiesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsBase
        {
            get
            {
                return this.IsBaseField;
            }
            set
            {
                this.IsBaseField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title
        {
            get
            {
                return this.TitleField;
            }
            set
            {
                this.TitleField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Type
        {
            get
            {
                return this.TypeField;
            }
            set
            {
                this.TypeField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceWCF.IMyPhotos")]
    public interface IMyPhotos
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFile/CreateNewFile", ReplyAction="http://tempuri.org/InterfaceFile/CreateNewFileResponse")]
        System.Threading.Tasks.Task<ServiceReferenceWCF.File> CreateNewFileAsync(string path, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFile/AddFile", ReplyAction="http://tempuri.org/InterfaceFile/AddFileResponse")]
        System.Threading.Tasks.Task<ServiceReferenceWCF.File> AddFileAsync(ServiceReferenceWCF.File toBeAdded);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFile/GetFileById", ReplyAction="http://tempuri.org/InterfaceFile/GetFileByIdResponse")]
        System.Threading.Tasks.Task<ServiceReferenceWCF.File> GetFileByIdAsync(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFile/GetAllFiles", ReplyAction="http://tempuri.org/InterfaceFile/GetAllFilesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceWCF.File>> GetAllFilesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFile/GetAllNonDeletedFiles", ReplyAction="http://tempuri.org/InterfaceFile/GetAllNonDeletedFilesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceWCF.File>> GetAllNonDeletedFilesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFile/EffectiveDeleteFile", ReplyAction="http://tempuri.org/InterfaceFile/EffectiveDeleteFileResponse")]
        System.Threading.Tasks.Task EffectiveDeleteFileAsync(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFile/DeleteFile", ReplyAction="http://tempuri.org/InterfaceFile/DeleteFileResponse")]
        System.Threading.Tasks.Task<bool> DeleteFileAsync(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceProperty/CreateProperty", ReplyAction="http://tempuri.org/InterfaceProperty/CreatePropertyResponse")]
        System.Threading.Tasks.Task<ServiceReferenceWCF.Property> CreatePropertyAsync(string title, string description, string type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceProperty/InitializeDefaultProperties", ReplyAction="http://tempuri.org/InterfaceProperty/InitializeDefaultPropertiesResponse")]
        System.Threading.Tasks.Task InitializeDefaultPropertiesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceProperty/AddProperty", ReplyAction="http://tempuri.org/InterfaceProperty/AddPropertyResponse")]
        System.Threading.Tasks.Task<ServiceReferenceWCF.Property> AddPropertyAsync(ServiceReferenceWCF.Property toBeAdded);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceProperty/GetPropertyByTitle", ReplyAction="http://tempuri.org/InterfaceProperty/GetPropertyByTitleResponse")]
        System.Threading.Tasks.Task<ServiceReferenceWCF.Property> GetPropertyByTitleAsync(string title);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceProperty/GetPropertyById", ReplyAction="http://tempuri.org/InterfaceProperty/GetPropertyByIdResponse")]
        System.Threading.Tasks.Task<ServiceReferenceWCF.Property> GetPropertyByIdAsync(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceProperty/GetAllProperties", ReplyAction="http://tempuri.org/InterfaceProperty/GetAllPropertiesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceWCF.Property>> GetAllPropertiesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceProperty/EditProperty", ReplyAction="http://tempuri.org/InterfaceProperty/EditPropertyResponse")]
        System.Threading.Tasks.Task<ServiceReferenceWCF.Property> EditPropertyAsync(System.Guid id, string title, string description);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceProperty/DeleteProperty", ReplyAction="http://tempuri.org/InterfaceProperty/DeletePropertyResponse")]
        System.Threading.Tasks.Task DeletePropertyAsync(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceProperty/ValidateDataType", ReplyAction="http://tempuri.org/InterfaceProperty/ValidateDataTypeResponse")]
        System.Threading.Tasks.Task<bool> ValidateDataTypeAsync(string dataType, string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFileProperty/CreateFileProperty", ReplyAction="http://tempuri.org/InterfaceFileProperty/CreateFilePropertyResponse")]
        System.Threading.Tasks.Task<ServiceReferenceWCF.FileProperty> CreateFilePropertyAsync(System.Guid fileID, System.Guid propertyId, string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFileProperty/AddFilePropertyToFile", ReplyAction="http://tempuri.org/InterfaceFileProperty/AddFilePropertyToFileResponse")]
        System.Threading.Tasks.Task<ServiceReferenceWCF.FileProperty> AddFilePropertyToFileAsync(ServiceReferenceWCF.FileProperty fileProperty);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFileProperty/GetPropertiesForFileId", ReplyAction="http://tempuri.org/InterfaceFileProperty/GetPropertiesForFileIdResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceWCF.Property>> GetPropertiesForFileIdAsync(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFileProperty/GetValueByFileIdAndPropertyId", ReplyAction="http://tempuri.org/InterfaceFileProperty/GetValueByFileIdAndPropertyIdResponse")]
        System.Threading.Tasks.Task<string> GetValueByFileIdAndPropertyIdAsync(System.Guid fileId, System.Guid propertyId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFileProperty/RemovePropertyForFile", ReplyAction="http://tempuri.org/InterfaceFileProperty/RemovePropertyForFileResponse")]
        System.Threading.Tasks.Task RemovePropertyForFileAsync(System.Guid propertyId, System.Guid fileId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    public interface IMyPhotosChannel : ServiceReferenceWCF.IMyPhotos, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    public partial class MyPhotosClient : System.ServiceModel.ClientBase<ServiceReferenceWCF.IMyPhotos>, ServiceReferenceWCF.IMyPhotos
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public MyPhotosClient() : 
                base(MyPhotosClient.GetDefaultBinding(), MyPhotosClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IMyPhotos.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MyPhotosClient(EndpointConfiguration endpointConfiguration) : 
                base(MyPhotosClient.GetBindingForEndpoint(endpointConfiguration), MyPhotosClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MyPhotosClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(MyPhotosClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MyPhotosClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(MyPhotosClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MyPhotosClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceWCF.File> CreateNewFileAsync(string path, string name)
        {
            return base.Channel.CreateNewFileAsync(path, name);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceWCF.File> AddFileAsync(ServiceReferenceWCF.File toBeAdded)
        {
            return base.Channel.AddFileAsync(toBeAdded);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceWCF.File> GetFileByIdAsync(System.Guid id)
        {
            return base.Channel.GetFileByIdAsync(id);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceWCF.File>> GetAllFilesAsync()
        {
            return base.Channel.GetAllFilesAsync();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceWCF.File>> GetAllNonDeletedFilesAsync()
        {
            return base.Channel.GetAllNonDeletedFilesAsync();
        }
        
        public System.Threading.Tasks.Task EffectiveDeleteFileAsync(System.Guid id)
        {
            return base.Channel.EffectiveDeleteFileAsync(id);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteFileAsync(System.Guid id)
        {
            return base.Channel.DeleteFileAsync(id);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceWCF.Property> CreatePropertyAsync(string title, string description, string type)
        {
            return base.Channel.CreatePropertyAsync(title, description, type);
        }
        
        public System.Threading.Tasks.Task InitializeDefaultPropertiesAsync()
        {
            return base.Channel.InitializeDefaultPropertiesAsync();
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceWCF.Property> AddPropertyAsync(ServiceReferenceWCF.Property toBeAdded)
        {
            return base.Channel.AddPropertyAsync(toBeAdded);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceWCF.Property> GetPropertyByTitleAsync(string title)
        {
            return base.Channel.GetPropertyByTitleAsync(title);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceWCF.Property> GetPropertyByIdAsync(System.Guid id)
        {
            return base.Channel.GetPropertyByIdAsync(id);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceWCF.Property>> GetAllPropertiesAsync()
        {
            return base.Channel.GetAllPropertiesAsync();
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceWCF.Property> EditPropertyAsync(System.Guid id, string title, string description)
        {
            return base.Channel.EditPropertyAsync(id, title, description);
        }
        
        public System.Threading.Tasks.Task DeletePropertyAsync(System.Guid id)
        {
            return base.Channel.DeletePropertyAsync(id);
        }
        
        public System.Threading.Tasks.Task<bool> ValidateDataTypeAsync(string dataType, string value)
        {
            return base.Channel.ValidateDataTypeAsync(dataType, value);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceWCF.FileProperty> CreateFilePropertyAsync(System.Guid fileID, System.Guid propertyId, string value)
        {
            return base.Channel.CreateFilePropertyAsync(fileID, propertyId, value);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceWCF.FileProperty> AddFilePropertyToFileAsync(ServiceReferenceWCF.FileProperty fileProperty)
        {
            return base.Channel.AddFilePropertyToFileAsync(fileProperty);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceWCF.Property>> GetPropertiesForFileIdAsync(System.Guid id)
        {
            return base.Channel.GetPropertiesForFileIdAsync(id);
        }
        
        public System.Threading.Tasks.Task<string> GetValueByFileIdAndPropertyIdAsync(System.Guid fileId, System.Guid propertyId)
        {
            return base.Channel.GetValueByFileIdAndPropertyIdAsync(fileId, propertyId);
        }
        
        public System.Threading.Tasks.Task RemovePropertyForFileAsync(System.Guid propertyId, System.Guid fileId)
        {
            return base.Channel.RemovePropertyForFileAsync(propertyId, fileId);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IMyPhotos))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IMyPhotos))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:8000/PC");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return MyPhotosClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IMyPhotos);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return MyPhotosClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IMyPhotos);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IMyPhotos,
        }
    }
}
