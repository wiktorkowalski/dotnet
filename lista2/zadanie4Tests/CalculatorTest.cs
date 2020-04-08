using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using zadanie4;

namespace zadanie4Tests
{
    [TestClass]
    public class CalculatorTest
    {
        Calculator calculator;

        [TestInitialize]
        public void Initialize()
        {
            calculator = Calculator.GetCalculator();
        }
        [TestCategory("Simple Math")]
        [TestMethod]
        [DataRow(2, "1+1")]
        [DataRow(18, "2*9")]
        [DataRow(-7, "2-9")]
        [DataRow(0, "0/1")]
        [DataRow(5, "5/1")]
        [DataRow(0.2, "1/5")]
        public void SimpleMathTest(double expected, string input)
        {
            Assert.AreEqual(expected, calculator.Calculate(input));
        }

        [TestCategory("Operator Order")]
        [TestMethod]
        [DataRow(7, "1+2*3")]
        [DataRow(5, "6/2*1+2")]
        public void OperatorOrderTest(double expected, string input)
        {
            Assert.AreEqual(expected, calculator.Calculate(input));
        }

        [TestCategory("0 Division")]
        [TestMethod]
        [DataRow(0, "1/0")]
        [DataRow(0, "0/0*0")]
        [DataRow(0, "1/0*8")]
        public void ZeroDivisionTest(double expected, string input)
        {
            Assert.AreEqual(expected, calculator.Calculate(input));
        }
    }
}
