using System.ServiceModel;

namespace WcfInternalServiceApplication
{
    [ServiceContract]
    public interface IInternalService
    {
        [OperationContract]
        string GetIceCreamFlavorById(int id);

        [OperationContract]
        string GetMochi();

        [OperationContract]
        string GetMochiIceCreamByFlavor(string flavor);
    }
}