using PaymentContext.Domain.ValuesObjects;
using PaymentContext.Shared.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PaymentContext.Domain.Entities
{
    public class Student : Entity
    {
        private IList<Subscription> _subscriptions;
        public Student(Name name,string firstName, string lastName, Document document, Email email)
        {
            Name = name;
            Document = document;
            Email = email;
            _subscriptions = new List<Subscription>();
        }

        public Name Name { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public Address Address { get; private set; }
        public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscriptions.ToArray(); } }

        public void AddSubscriptions(Subscription subscription)
        {
            // cancela todas as ativas e coloca a que chega como principal.
            foreach (var sub in Subscriptions)
            {
                sub.Inactivate();
            }
            _subscriptions.Add(subscription);
        }
    }
}
