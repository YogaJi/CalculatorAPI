using System;

namespace CalculatorLibrary
{
    public class Calculator
    {
        
        static void Main(string[] args)
        {
            double valueA;
            double valueB;
            string userInput;
            Console.WriteLine("Welcome to the Calculator:");
            Console.WriteLine("Please input a valueA number");
            userInput = Console.ReadLine();
            valueA = Convert.ToDouble(userInput);

            Console.WriteLine("Please enter a valueB number");
            userInput = Console.ReadLine();
            valueB = Convert.ToDouble(userInput);

            var calculate = new Calculator();
            Console.WriteLine("Addition: " + valueA + " + " + valueB + " = " + calculate.Add(valueA, valueB));
            Console.WriteLine("Subtraction: " + valueA + " - " + valueB + " = " + calculate.Subtract(valueA, valueB));     
            Console.WriteLine("Multiplication: " + valueA + " * " + valueB + " = " + calculate.Multiple(valueA, valueB));
            if(valueB == 0)
            {
                Console.WriteLine("Division Error");
            }
            else
            {
                Console.WriteLine("Division: " + valueA + " / " + valueB + " = " + calculate.Divide(valueA, valueB));
            }
    
        }//end of static 
        
        //Methods:
        public double Add(double valueA, double valueB)
        {
            return valueA + valueB;
        }

        public double Subtract(double valueA, double valueB)
        {
            return valueA - valueB;
        }

        public double Multiple(double valueA, double valueB)
        {
            return valueA * valueB;
        }

        public double? Divide(double valueA, double valueB)
        {
            if(valueB == 0)
            {
                throw new DivideByZeroException();
            }
            else
            {
                return valueA / valueB;
            }
  
        }
    }
}
