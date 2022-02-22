using CalculatorLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Project
{
    [TestClass]
    //this test is for CalculatorLibrary terminal - Add
    public class CalculatorLibraryAddTest
    {
        private readonly Calculator _calculator;
        public CalculatorLibraryAddTest()
        {
            _calculator = new Calculator();
        }

        [TestMethod]
        [DataRow(1, 2, 3)]
        [DataRow(-1, -3, -4)]
        [DataRow(0.01, 0.6600, 0.67)]
        [DataRow(-0.05, -0.05, -0.1)]
        //Test 1: Add()
        //DataTest: positive\negative\decimal\negative-decimal
        public void Test2_Add_Input_Int_Double_Negative_Postive(double valueA, double valueB, double expected)
        {
            Assert.AreEqual(expected, _calculator.Add(valueA, valueB));
        }

        [TestMethod]
        [DataRow(0, 0, 0)]
        [DataRow(7.8889, 0, 7.8889)]
        [DataRow(0, -10, -10)]
        [DataRow(0, 0.91, 0.91)]
        //Test 2: Add()
        //DataTest: zero
        public void Test2_Add_Zero(double valueA, double valueB, double expected)
        {
            Assert.AreEqual(expected, _calculator.Add(valueA, valueB));
        }

        //further test
        /*      [TestMethod]
                [DataRow("a")]
                [DataRow("h")]
                [DataRow("-")]
                [DataRow("}")]
                public void Test2_InputSingleDigitAsString_ReturnInvalidArgumentException(string userInput)
                {
                    Assert.ThrowsException<ArgumentException>(() => _calculator.checkInput(userInput));
                }*/
    }
}

