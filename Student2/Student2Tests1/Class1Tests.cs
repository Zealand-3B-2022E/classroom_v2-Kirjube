using Microsoft.VisualStudio.TestTools.UnitTesting;
using Student2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student2.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void Class1Test()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ReturnNavnOgAdresseTest()
        {
            //Arrange

            string expectedresult = "Den studerendes navn er: Søren. Den studerendes adresse er Kirkegårdsvej 2.";
            string inputName = "Søren";
            string inputAdresse = "Kirkegårdsvej 2";
            string actualresult;

            //Act 
            Class1 studentClass = new Class1(inputAdresse, inputName);
            actualresult = studentClass.ReturnNavnOgAdresse();

            //Assert
            Assert.AreEqual(expectedresult, actualresult);
        }
    }
}