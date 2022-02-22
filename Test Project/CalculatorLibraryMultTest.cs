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
    //this test is for CalculatorLibrary terminal - Multiple
    public class CalculatorLibraryMultTest
    {
        private readonly Calculator _calculator;
        public CalculatorLibraryMultTest()
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
        //Test 8: Multiple()
        //Data: positive\negative\decimal\negative-decimal
        public void Test2_Multiple_Input_Int_Double_Negative_Postive_Zero(double valueA, double valueB, double expected)
        {
            Assert.AreEqual(expected, _calculator.Multiple(valueA, valueB));
        }

  
        [TestMethod]
        [DataRow(0, 77894, 0)]
        [DataRow(775, 0, 0)]
        [DataRow(0, -9.70, 0)]
        [DataRow(0, 0, 0)]
        //Test 9: Multiple()
        //Data: zero
        public void Test2_Multiple_Input_Zero(double valueA, double valueB, double expected)
        {
            Assert.AreEqual(expected, _calculator.Multiple(valueA, valueB));
        }

    }
}

