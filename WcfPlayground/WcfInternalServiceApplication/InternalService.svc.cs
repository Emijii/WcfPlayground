namespace WcfInternalServiceApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class InternalService : IInternalService
    {
        public string GetMochi()
        {
            return "Hi Mochi! :-)";
        }

        public string GetMochiIceCreamByFlavor(string flavor)
        {
            return string.Format("Your {0} ice cream is served!", flavor);
        }
    }
}