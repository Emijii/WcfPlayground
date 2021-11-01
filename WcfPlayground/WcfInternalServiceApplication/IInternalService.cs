using System.ServiceModel;

namespace WcfInternalServiceApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IInternalService
    {
        [OperationContract]
        string GetMochi();

        [OperationContract]
        string GetMochiIceCreamByFlavor(string flavor);
    }
}