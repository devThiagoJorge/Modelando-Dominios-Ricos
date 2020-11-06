using PaymentContext.Shared.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Domain.ValuesObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            if (string.IsNullOrEmpty(FirstName) && string.IsNullOrEmpty(LastName))
            {
                AddNotification("FirstName", "Nome Inválido");
                AddNotification("LastName", "Sobrenome Inválido");
            }
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}
