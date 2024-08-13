using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPW211_UnitTestStarterCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_UnitTestStarterCode.Tests
{
    [TestClass()]
    public class SimpleMathTests
    {
        [TestMethod()]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Add_TwoNumbers_ReturnsSum(double num1, double num2)
        {
            double expected = num1 + num2;
            double final = SimpleMath.Add(num1, num2);

            Assert.AreEqual(expected, final);
        }

        [TestMethod]
        [DataRow(5, 3)]
        [DataRow(0, 5)]
        [DataRow(-2, 5)]
        [DataRow(2.5, 2.5)]
        public void Multiply_TwoNumbers_ReturnsProduct(double num1, double num2)
        {
            double expected = num1 * num2;
            double result = SimpleMath.Multiply(num1, num2);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Divide_DenominatorZero_ThrowsArgumentException()
        {
            Assert.ThrowsException<ArgumentException>((() => SimpleMath.Divide(0, 0)));
        }

        [TestMethod]
        [DataRow(10, 2)]
        [DataRow(20, 5)]
        [DataRow(15, 3)]
        [DataRow(100, 25)]
        [DataRow(50, 10)]
        public void Divide_TwoNumbers_ReturnsProduct(double num1, double num2)
        {
            double expected = num1 / num2;
            double result = SimpleMath.Divide(num1, num2);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Subtract_TwoNumbers_ReturnsProduct(double num1, double num2)
        {
            double expected = num1 - num2;
            double result = SimpleMath.Subtract(num1, num2);

            Assert.AreEqual(expected, result);
        }
    }
}