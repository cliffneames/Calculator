using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Add2Numbers(){
            int result = Calculator.Add(10, 5);
            Assert.AreEqual(15, result);
            
        }

        [TestMethod]
        public void Subtract2Numbers(){
            int result = Calculator.Subtract(10, 5);
            Assert.AreEqual(5, result);

        }

        [TestMethod]
        public void Multiply2Numbers(){
            int result = Calculator.Multiply(10, 5);
            Assert.AreEqual(50, result);

        }

        [TestMethod]
        public void Divide2Numbers(){
            int result = Calculator.Divide(10, 5);
            Assert.AreEqual(2, result);

        }

        [TestMethod]
        public void Square2Numbers(){
            double result = Calculator.Exponent(10, 0);
            Assert.AreEqual(1, result);

        }

        [TestMethod]
        public void NoNegatives()
        {
            Assert.ThrowsException<ArgumentException>(() => Calculator.Add(-1, 10));
            Assert.ThrowsException<ArgumentException>(() => Calculator.Add(10, -1));

        }
    }
}
