using PaymentContext.Domain.ValuesObjects;
using System;
using System.Collections.Generic;using System.Text;

namespace PaymentContext.Domain.Entities
{
    public class BoletoPayment : Payment
    {
        public BoletoPayment(
            string barCode, 
            string boletoNumber,
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
            BarCode = barCode;
            BoletoNumber = boletoNumber;
        }

        public string BarCode { get; private set; }
        public string BoletoNumber { get; private set; }
    }
}
