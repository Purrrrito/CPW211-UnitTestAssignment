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
            // Use the DataRow values to test the Add method
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
            // Use a few pairs of values to test the Multiply method
            double expected = num1 * num2;
            double result = SimpleMath.Multiply(num1, num2);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Divide_DenominatorZero_ThrowsArgumentException()
        {
            // Divide by zero should throw an argument exception with a message
            // "Denominator cannot be zero"
            Assert.Fail();
        }

        // TODO: Test Divide method with two valid numbers

        // TODO: Test subtract method with two valid numbers
    }
}