using PaymentContext.Domain.ValuesObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Domain.Entities
{
    public class PaypalPayment : Payment
    {
        public PaypalPayment(string transactionCode,
            DateTime payDate, 
            DateTime expireDate, 
            decimal total, 
            decimal totalPaid,
            Document document, 
            string payer,
            Address address, 
            Email email) : 
            base(
                payDate,
                expireDate, 
                total, 
                totalPaid, 
                document, 
                payer, 
                address, 
                email)
        {
            TransactionCode = transactionCode;
        }

        public string TransactionCode { get; private set; }
    }

}
