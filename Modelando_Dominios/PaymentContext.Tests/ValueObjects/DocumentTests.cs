using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValuesObjects;

namespace PaymentContext.Tests.ValueObjects
{
    [TestClass]
    public class DocumentTests
    {
        // Red, Green, Refactor -> Aplicar testes

        [TestMethod]
        public void ShouldReturnErrorWhenCNPJIsInvalid()
        {
            var doc = new Document("123", EDocumentType.CNPJ);
            var result = doc.ValidateNumber();
            Assert.IsFalse(result);     
        }

        [TestMethod]
        public void ShouldReturnSuccessWhenCNPJIsValid()
        {
            var doc = new Document("12345678912345", EDocumentType.CNPJ);
            var result = doc.ValidateNumber();
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ShouldReturnErrorWhenCPFIsInvalid()
        {
            var doc = new Document("1245", EDocumentType.CPF);
            var result = doc.ValidateNumber();
            Assert.IsFalse(result);
        }


        [TestMethod]
        public void ShouldReturnSuccessWhenCPFIsValid()
        {
            var doc = new Document("12345678999", EDocumentType.CPF);
            var result = doc.ValidateNumber();
            Assert.IsTrue(result);
        }


    }
}
