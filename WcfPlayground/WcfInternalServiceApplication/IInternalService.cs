using System.ServiceModel;

namespace WcfInternalServiceApplication
{
    [ServiceContract]
    public interface IInternalService
    {
        [OperationContract]
        string GetMochi();

        [OperationContract]
        string GetMochiIceCreamByFlavor(string flavor);
    }
}