namespace DemopensionPartner.Models
{
    public class Customer
    {
        public string danishSSN { get; set; } = "";
        public string pensionDate { get; set; } = "";
        public int salary { get; set; } = 0;
        public int coronaSalary { get; set; } = 0;
        public int activeVSOIncome { get; set; } = 0;
        public int inactiveVSOIncome { get; set; } = 0;
        public int pensionIncome { get; set; } = 0;
        public int pensionSaving { get; set; } = 0;
        public int capitalIncome { get; set; } = 0;
        public int liquidity { get; set; } = 0;
        public bool nationalChurchMember { get; set; } = true;
        public int yearsAbroad { get; set; } = 0;
    }

}
