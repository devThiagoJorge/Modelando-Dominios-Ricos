using PaymentContext.Domain.ValuesObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Domain.Entities
{
    public abstract class Payment // Não posso instanciar um pagamento.
    {
        protected Payment(DateTime payDate, DateTime expireDate, decimal total, decimal totalPaid, Document document, string payer, Address address, Email email)
        {
            Number = Guid.NewGuid().ToString().Replace("-","").Substring(0, 10).ToUpper();
            PayDate = payDate;
            ExpireDate = expireDate;
            Total = total;
            TotalPaid = totalPaid;
            Document = document;
            Payer = payer;
            Address = address;
            Email = email;
        }

        public string Number { get; private set; }
        public DateTime PayDate { get; private set; }
        public DateTime ExpireDate { get; private set; }
        public decimal Total { get; private set; }
        public decimal TotalPaid { get; private set; }
        public Document Document { get; private set; }
        public string Payer { get; private set; }
        public Address Address { get; private set; }
        public Email Email { get; private set; }
    }
}
