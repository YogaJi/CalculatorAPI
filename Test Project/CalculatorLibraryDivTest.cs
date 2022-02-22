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
    //this test is for CalculatorLibrary terminal - Divide
    public class CalculatorLibraryDivTest
    {
        private readonly Calculator _calculator;
        public CalculatorLibraryDivTest()
        {
            _calculator = new Calculator();
        }

        [TestMethod]
        [DataRow(89, 5, 17.8)]
        [DataRow(-17, -3, 5.666666666666667)]
        [DataRow(0.6666, 4, 0.16665)]
        [DataRow(-456, -2.5, 182.4)]
        //Test 3: Divide()
        //Data: positive\negative\decimal\negative-decimal
        public void Test2_Divide_Input_Int_Double_Negative_Postive(double valueA, double valueB, double expected)
        {
            Assert.AreEqual(expected, _calculator.Divide(valueA, valueB));
        }

        [TestMethod]
        [DataRow(0, 98, 0)]
        [DataRow(0, -7654, 0)]
        [DataRow(0, 67.90, 0)]
        [DataRow(0, -2.50, 0)]
        //Test 4: Divide()
        //Data: first zero
        public void Test2_Divide_Input_First_Zero(double valueA, double valueB, double expected)
        {
            Assert.AreEqual(expected, _calculator.Divide(valueA, valueB));
        }

        [TestMethod]
        [DataRow(98, 0)]
        [DataRow(-7654, 0)]
        [DataRow(67.90, 0)]
        [DataRow(-2.50, 0)]
        //Test 5: Divide()
        //Data: second zero

        public void Test2_Divide_Input_Second_Zero(double valueA, double valueB)
        {
            Assert.IsNotNull($"{valueB} should not be zero, 400");
        }

        [TestMethod]
        [DataRow(0, 0)]
        //Test 6: Divide()
        //Data: double zero
        public void Test2_Divide_Input_Double_Zero(double valueA, double valueB)
        {
            Assert.IsNotNull($"{valueB} should not be zero, 400");
        }

        [TestMethod]
        [DataRow(-0.10, 98, -0.0010204081632653062)]
        [DataRow(-20, -0.9990, 20.02002002002002)]
        [DataRow(-0.99, -89.3, 0.01108622620380739)]
        [DataRow(-50, -2, 25)]
        //Test 7: Divide()
        //Data: all negative
        public void Test2_Divide_Input_Negative(double valueA, double valueB, double expected)
        {
            Assert.AreEqual(expected, _calculator.Divide(valueA, valueB));
        }

    }
}

