using EventVersioning.Events;

namespace EventVersioning.Models 
{
    public abstract class Entity 
    {
        protected List<IEvent> _events = new List<IEvent>();

        public IReadOnlyList<IEvent> Events => _events.AsReadOnly();
    }

    public class BankAccount : Entity
    {
        public string IBAN { get; set; }

        public BankAccountOwner Owner { get; set;}
    }

    public class BankAccountOwner : Entity 
    {
        public string FistName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }
    }
}