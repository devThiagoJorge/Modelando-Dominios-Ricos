using PaymentContext.Shared.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Domain.ValuesObjects
{
    public class Email : ValueObject
    {
        public Email(string address)
        {
            Address = address;
        }

        public string Address { get; private set; }
    }
}
