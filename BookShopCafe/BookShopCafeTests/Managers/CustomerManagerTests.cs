using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookShopCafe.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLibrary;
using System.ComponentModel.DataAnnotations;

namespace BookShopCafe.Managers.Tests
{
    
    [TestClass()]

    public class CustomerManagerTests
    {
        private ICustomerManager mgr = new CustomerManager();

        [TestMethod()]
        [DataRow(3,null,"Email@gmail.com","87654321")]
        [DataRow(3,"   ","Email@gmail.com","87654321")]
        [DataRow(3,"","Email@gmail.com","87654321")]
        [ExpectedException(typeof(ArgumentException))]  
        public void CreateNameTest(int id, string name, string email, string phone)
        {
            //arrange
            CustomerManager customerManager = new();
            Customer customer = new Customer(id, name, email, phone);

            //Act
            customerManager.Create(customer);

            //Assert
            Assert.Fail();
        }
        [TestMethod()]

        public void CreateAddCustomerTest()
        {
            //arrange
            CustomerManager customManager = new();
            Customer _expectedCustomer = new Customer(4, "Ulla Mikkelsen","Ulla.Mikkelsen@gmail.com", "54465224");

            //Act
            Customer _actualCustomer = customManager.Create(_expectedCustomer);

            //Assert
            Assert.AreEqual(_expectedCustomer, _actualCustomer);
        }


        [TestMethod()]
        public void DeleteTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetTest()
        {
            List<Customer> _expectedList = new List<Customer>() { new Customer { Id = 1, Name = "Belial", Email= "Belial@gmail.com", Phone = "12345678"},
            new Customer { Id = 2, Name = "Behemoth", Email = "Behemoth@gmail.com", Phone = "23568945" } };
            List<Customer> _actualList = mgr.Get();

            Assert.AreEqual(_expectedList, _actualList);
        }

        [TestMethod()]
        public void UpdateTest()
        {
            Assert.Fail();
        }
    }
}