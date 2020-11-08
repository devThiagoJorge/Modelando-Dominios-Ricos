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
    

        public bool ValidateNumber()
        {
            if (DocumentType == EDocumentType.CPF && Number.Length == 11)
                return true;

            else if (DocumentType == EDocumentType.CNPJ && Number.Length == 14)
                return true;

            return false;
        }
    
    }
}
