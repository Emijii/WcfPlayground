namespace WcfInternalServiceApplication
{
    public class InternalService : IInternalService
    {
        public string GetIceCreamFlavorById(int id)
        {
            throw new System.NotImplementedException();
        }

        public string GetMochi()
        {
            return "Hi Mochi! :-) - Internal Service Called";
        }

        public string GetMochiIceCreamByFlavor(string flavor)
        {
            return string.Format("Your {0} ice cream is served! - Internal Service Called", flavor);
        }
    }
}