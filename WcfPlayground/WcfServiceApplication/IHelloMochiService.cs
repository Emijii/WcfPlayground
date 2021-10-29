using System.Runtime.Serialization;
using System.ServiceModel;

namespace WcfServiceApplication
{
    [ServiceContract]
    public interface IHelloMochiService
    {
        [OperationContract]
        string GetMochi();

        [OperationContract]
        string GetMochiIceCreamByFlavor(string flavor);
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        private bool boolValue = true;
        private string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}