using PaymentContext.Domain.Enums;
using PaymentContext.Shared.ValueObject;

namespace PaymentContext.Domain.ValuesObjects
{
    public class Document : ValueObject
    {
        public Document(string number, EDocumentType documentType)
        {
            Number = number;
            DocumentType = documentType;
        }

        public string Number { get; private set; }
        public EDocumentType DocumentType { get; private set; }
    }
}
