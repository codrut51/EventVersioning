namespace EventVersioning.Models 
{
    public class BankAccount 
    {
        public string IBAN { get; set; }

        public BankAccountOwner Owner { get; set;}
    }

    public class BankAccountOwner {
        public string FistName { get; set; }

        public string LastName { get; set; }
    }
}