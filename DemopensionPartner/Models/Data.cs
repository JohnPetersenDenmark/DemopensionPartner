namespace DemopensionPartner.Models
{
    public class Data
    {
        public Data()
        {
            person = new Person();
            customer = new Customer();
            spouse = new Spouse();
        }
        public Person person { get; set; }
        public Customer customer { get; set; }
        public Spouse spouse { get; set; }
        public string maritalStatus { get; set; } = "Unknown";
        public bool spouseIsSeniorCitizen { get; set; } = false;
        public string calculationDate { get; set; } = "";
        public bool includePublicPensionExtraSupplement { get; set; } = false;
    }

}
