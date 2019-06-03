using Microsoft.VisualStudio.TestTools.UnitTesting;
using DomainLibrary1;
using System;

namespace PizzaBoxTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestCost()
        {
            DomainLibrary1.PizzaOrder d = new DomainLibrary1.PizzaOrder();
            decimal expected = 5.5M;
            decimal actual = d.Cost("small",2);

            Assert.AreEqual(expected, actual);           
        }
        [TestMethod]
        public void TestTotalCost()
        {
            DomainLibrary1.PizzaOrder d = new DomainLibrary1.PizzaOrder();
            decimal expected = 5.5M;
            decimal actual = d.TotalCost(0,"small", 2);

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Testcheck()
        {
            DomainLibrary1.PizzaOrder d = new DomainLibrary1.PizzaOrder();
            d.cost = 5001;
            bool expected = false;
            bool actual=d.checkcost();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestDate()
        {
            DomainLibrary1.PizzaOrder d = new DomainLibrary1.PizzaOrder();
            
            bool expected = false;
            bool actual = d.canTheyLogIn(1,1,DateTime.Now);
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestCount()
        {
            DomainLibrary1.PizzaOrder d = new DomainLibrary1.PizzaOrder();
            d.orderCount = 200;
            bool expected = false;

            bool actual = d.Count();
            Assert.AreEqual(expected, actual);

        }
    }
}
