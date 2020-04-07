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
        [DataRow(2,"1+1")]
        public void SimpleMathTest(double expected, string input)
        {
            Assert.AreEqual(expected, calculator.Calculate(input));
        }

        [TestCategory("Operator Order")]
        [TestMethod()]
        [DataRow(1,"1*1")]
        [DataRow(7,"1+2*3")]
        public void OperatorOrderTest(double expected, string input)
        {
            Assert.AreEqual(expected, calculator.Calculate(input));
        }
    }
}
