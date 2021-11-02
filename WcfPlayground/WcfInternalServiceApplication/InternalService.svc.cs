namespace WcfInternalServiceApplication
{
    public class InternalService : IInternalService
    {
        public string GetMochi()
        {
            return "Hi Mochi! :-) - Internal Service Called AGAIN";
        }

        public string GetMochiIceCreamByFlavor(string flavor)
        {
            return string.Format("Your {0} ice cream is served! - Internal Service Called AGAIN", flavor);
        }
    }
}