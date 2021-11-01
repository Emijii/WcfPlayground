using System.ServiceModel;

namespace WcfExternalServiceApplication
{
    [ServiceContract]
    public interface IExternalService
    {
        [OperationContract]
        string GetMochi();

        [OperationContract]
        string GetMochiIceCreamByFlavor(string flavor);
    }
}