using Microsoft.VisualStudio.TestTools.UnitTesting;
using Phone.BL;
using System;

namespace PhoneBookTest
{
    [TestClass]
    public class ContactTest
    {
        [TestMethod]
        public void NameSurnameTest()
        {
            //Arrange (zaranżuj test)
            Contact contact = new Contact();
            contact.Name = "Andrzej";
            contact.Surname = "Bąk";
            string NameSurname = "Andrzej, Bąk";
            //ACT (działaj)
            string actual = contact.NameSurname;
            //Assert (potwierdź test)
            Assert.AreEqual(NameSurname, actual);
        }
        [TestMethod]
        public void NameSurnameNameEmpty()
        {
            //Arrange (zaranżuj test)
            Contact contact = new Contact();
            contact.Surname = "Bąk";
            string NameSurname = "Bąk";
            //ACT (działaj)
            string actual = contact.NameSurname;
            //Assert (potwierdź test)
            Assert.AreEqual(NameSurname, actual);
        }
        [TestMethod]
        public void NameSurnameSurnameEmpty()
        {
            //Arrange (zaranżuj test)
            Contact contact = new Contact();
            contact.Name = "Andrzej";
            string NameSurname = "Andrzej";
            //ACT (działaj)
            string actual = contact.NameSurname;
            //Assert (potwierdź test)
            Assert.AreEqual(NameSurname, actual);
        }
        [TestMethod]
        public void ValidateContactTest()
        {
            //Arrange (zaranżuj test)
            Contact contact = new Contact();
            contact.Name = "Andrzej";
            contact.Surname = "Bąk";
            contact.PhoneNumber = "+48 555 555 555";
            //ACT (działaj)
            bool validOk = contact.Validate();
            //Assert (potwierdź test)
            Assert.AreEqual(validOk, true);
        }
        [TestMethod]
        public void ValidateNameTest()
        {
            //Arrange (zaranżuj test)
            Contact contact = new Contact();
            contact.Surname = "Bąk";
            contact.PhoneNumber = "555555555";
            //ACT (działaj)
            bool validOk = contact.Validate();
            //Assert (potwierdź test)
            Assert.AreEqual(validOk, false);
        }
        [TestMethod]
        public void ValidateSurNameTest()
        {
            //Arrange (zaranżuj test)
            Contact contact = new Contact();
            contact.Name = "Andrzej";
            contact.PhoneNumber = "5555555";
            //ACT (działaj)
            bool validOk = contact.Validate();
            //Assert (potwierdź test)
            Assert.AreEqual(validOk, false);
        }
        [TestMethod]
        public void ValidatePhoneTest()
        {
            //Arrange (zaranżuj test)
            Contact contact = new Contact();
            contact.Name = "Andrzej";
            contact.Surname = "Bąk";
            //ACT (działaj)
            bool validOk = contact.Validate();
            //Assert (potwierdź test)
            Assert.AreEqual(validOk, false);
        }
    }
}
