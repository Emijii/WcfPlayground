using WcfInternalServiceApplication;

namespace WcfExternalServiceApplication
{
    public class ExternalService : IExternalService
    {
        public string GetMochi()
        {
            InternalService internalService = new InternalService();
            return internalService.GetMochi();
        }

        public string GetMochiIceCreamByFlavor(string flavor)
        {
            InternalService internalService = new InternalService();
            return internalService.GetMochiIceCreamByFlavor(flavor);
        }
    }
}