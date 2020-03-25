using System.ServiceModel;

namespace ObjectWCF
{
    [ServiceContract]
    interface IPostComment : InterfacePost, InterfaceComment
    {
    }
}
