using Microsoft.VisualStudio.TestTools.UnitTesting;
using ASP.Net_Core_Web_API;
using ASP.Net_Core_Web_API.Controllers;
using System;

namespace Test_Project
{
    [TestClass]
    public class CalculatorTest
    {
        private readonly CalculateController _CalculateController;

        public CalculatorTest()
        {
            _CalculateController = new CalculateController();
        }


        [TestMethod]
        [DataRow(1, 2, 3)]
        [DataRow(-1, -3, -4)]
        [DataRow(0.01, 0.6600, 0.67)]
        [DataRow(-0.05, -0.05, -0.1)]
        //Test: Add()
        //DataTest: positive\negative\decimal\negative-decimal
        public void Test_Add_Input_Int_Double_Negative_Postive(double valueA, double valueB, double expected)
        {
            
            Assert.AreEqual(expected, _CalculateController.Add(valueA, valueB));
        }

       [TestMethod]
        [DataRow(2, 1, 1)]
        [DataRow(-900, -90, -810)]
        [DataRow(0.68, 0.07, 0.6100000000000001)]//problem
        [DataRow(-47, 88, -135)]
        [DataRow(0, -90, 90)]
        [DataRow(65, 0, 65)]
        //Test 2: Subtract()
        //Data: positive\negative\decimal\negative-decimal\zero
        public void Test_Subtract_Input_Int_Double_Negative_Postive_Zero(double valueA, double valueB, double expected)
        {
            Assert.AreEqual(expected, _CalculateController.Subtract(valueA, valueB));
        }

        [TestMethod]
        [DataRow(32, 12, 384)]
        [DataRow(-55, -23, 1265)]
        [DataRow(2.68, 6.87, 18.4116)]
        [DataRow(-589.7, 325.90, -192183.23)]
        [DataRow(-44.568, 0, 0)]
        [DataRow(0, 77894, 0)]
        //Test 2: Add()
        //Data: positive\negative\decimal\negative-decimal\zero
        public void Test_Multiple_Input_Int_Double_Negative_Postive_Zero(double valueA, double valueB, double expected)
        {
            Assert.AreEqual(expected, _CalculateController.Multiple(valueA, valueB));
        }

        [TestMethod]
        [DataRow(89, 5, 17.8)]
        [DataRow(-17, -3, 5.666666666666667)]
        [DataRow(0.6666, 4, 0.16665)]
        [DataRow(-456, -2.5, 182.4)]
        //Test 3: Divide()
        //Data: positive\negative\decimal\negative-decimal
        public void Test_Divide_Input_Int_Double_Negative_Postive(double valueA, double valueB, double expected)
        {
            Assert.AreEqual(expected, _CalculateController.Divide(valueA, valueB));
        }

        [TestMethod]
        [DataRow(0, 98, 0)]
        [DataRow(0, -7654, 0)]
        [DataRow(0, 67.90, 0)]
        [DataRow(0, -2.50, 0)]
        //Test 4: Divide()
        //Data: first zero
        public void Test_Divide_Input_First_Zero(double valueA, double valueB, double expected)
        {
            Assert.AreEqual(expected, _CalculateController.Divide(valueA, valueB));
        }

        /*        [TestMethod]
                [DataRow(98, 0)]
                [DataRow(-7654, 0)]
                [DataRow(67.90, 0)]
                [DataRow(-2.50, 0)]
                //Test 4: Divide()
                //Data: first zero
                public void Test_Divide_Input_Second_Zero(double valueA, double valueB)
                {
                    var result = _CalculateController.Divide(valueA,valueB);
                    Assert.IsNull(result, $"{valueB} should not be zero, 400");
                }*/
        [TestMethod]
        [DataRow(98, 0)]
        [DataRow(-7654, 0)]
        [DataRow(67.90, 0)]
        [DataRow(-2.50, 0)]

        public void Test_Divide_Input_Second_Zero(double valueA, double valueB)
        {
       
            //var result = _CalculateController.Divide(2, valueB);
            // Assert.AreEqual(null, _CalculateController.Divide(2, valueB));
            //Assert.IsNull(result, $"{valueB} should not be zero, 400");
                //Assert.AreEqual(null,_CalculateController.Divide(valueA, valueB));
            Assert.ThrowsException<ArgumentException>(() => _CalculateController.Divide(valueA, valueB));
        }

    }
}
