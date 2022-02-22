using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CalculatorLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Project
{
    [TestClass]
    //this test is for CalculatorLibrary terminal - Subtract
    public class CalculatorLibrarySubTest
    {
        private readonly Calculator _calculator;
        public CalculatorLibrarySubTest()
        {
            _calculator = new Calculator();
        }

        [TestMethod]
        [DataRow(32, 12, 384)]
        [DataRow(-55, -23, 1265)]
        [DataRow(2.68, 6.87, 18.4116)]
        [DataRow(-589.7, 325.90, -192183.23)]
        [DataRow(-44.568, 0, 0)]
        [DataRow(0, 77894, 0)]
        //Test 10: Multiple()
        //Data: positive\negative\decimal\negative-decimal
        public void Test2_Multiple_Input_Int_Double_Negative_Postive_Zero(double valueA, double valueB, double expected)
        {
            Assert.AreEqual(expected, _calculator.Multiple(valueA, valueB));
        }


        [TestMethod]
        [DataRow(0, -90, 90)]
        [DataRow(65, 0, 65)]
        [DataRow(0.78, 0, 0.78)]
        [DataRow(0, 0, 0)]
        //Test 11: Subtract()
        //Data: zero
        public void Test2_Subtract_Zero(double valueA, double valueB, double expected)
        {
            Assert.AreEqual(expected, _calculator.Subtract(valueA, valueB));
        }

    }
}

