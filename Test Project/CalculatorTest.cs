using Microsoft.VisualStudio.TestTools.UnitTesting;
using ASP.Net_Core_Web_API;
using ASP.Net_Core_Web_API.Controllers;

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
        public void Test_Add_Input_Int_Double_Negative_Postive(double valueA, double valueB, double expected)
        {
            
            Assert.AreEqual(expected, _CalculateController.Add(valueA, valueB));
        }

       [TestMethod]
        [DataRow(1, 2, -1)]
        [DataRow(-1, -3, 2)]
        [DataRow(1, 5, -4)]
        [DataRow(-1, 1, -2)]
        public void Test_Subtract_Input_Int_Double_Negative_Postive(double valueA, double valueB, double expected)
        {
            Assert.AreEqual(expected, _CalculateController.Subtract(valueA, valueB));
        }

        [TestMethod]
        [DataRow(1, 2, 2)]
        [DataRow(-1, -3, 3)]
        [DataRow(0.1, 0.6, 0.06)]
        [DataRow(-5, 5, -25)]
        public void Test_Multiple_Input_Int_Double_Negative_Postive(double valueA, double valueB, double expected)
        {
            Assert.AreEqual(expected, _CalculateController.Multiple(valueA, valueB));
        }

        [TestMethod]
        [DataRow(1, 2, 0.5)]
        [DataRow(-1, -1, 1)]
        [DataRow(0.1, 2, 0.05)]
        [DataRow(-5, -0.5, 10)]
        public void Test_Divide_Input_Int_Double_Negative_Postive(double valueA, double valueB, double expected)
        {
            Assert.AreEqual(expected, _CalculateController.Divide(valueA, valueB));
        }
    }
}
