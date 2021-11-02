namespace WcfServiceApplication
{
    public class HelloMochi : IHelloMochiService
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