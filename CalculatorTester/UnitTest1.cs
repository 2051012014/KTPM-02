using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
namespace CalculatorTester
{
    [TestClass]
    public class UnitTest1
    {
        private Calculation c;
        [TestInitialize]
        public void SetUp()
        {
            this.c = new Calculation(10, 5);
        }
        [TestMethod] // 1 test case
        public void TestAddOperator()
        {
            int expected, actual;
            //Calculation c = new Calculation(10, 5);
            expected = 15;
            actual = c.Exectute("+");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestSubOperator()
        {
            int expected, actual;
            //Calculation c = new Calculation(10, 5);
            expected = 5;
            actual = c.Exectute("-");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMulOperator()
        {
            int expected, actual;
            //Calculation c = new Calculation(10, 5);
            expected = 50;
            actual = c.Exectute("*");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestDivOperator()
        {
            int expected, actual;
            //Calculation c = new Calculation(10, 5);
            expected = 2;
            actual = c.Exectute("/");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivbyZero()
        {
            int expected, actual;
            Calculation c = new Calculation(10, 0);
            expected = 2;
            actual = c.Exectute("/");
            Assert.AreEqual(expected, actual);
        }
    }
}
