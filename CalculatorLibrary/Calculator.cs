using System;

namespace CalculatorLibrary
{
    public class Calculator
    {
        
        static void Main(string[] args)
        {
            //set value A & value B
            double valueA;
            double valueB;
            //set user input as string
            string userInput;

            Console.WriteLine("Welcome to the Calculator:");
            Console.WriteLine("Please input a valueA number");

            //read user input and convert
            userInput = Console.ReadLine();

            //check if userInput is a valid number with checkInput function
            if (checkInput(userInput) == false)
            {
                Console.WriteLine("invalid number");
                return;
            }
            else
            {
                //valid then continue
                valueA = Convert.ToDouble(userInput);
            }

            //set value b and read user input and convert
            Console.WriteLine("Please enter a valueB number");

            userInput = Console.ReadLine();

            //check if userInput is a valid number with checkInput function
            checkInput(userInput);
            if (checkInput(userInput) == false)
            {
                Console.WriteLine("invalid number");
                return;
            }
            else
            {
                //valid then continue
                valueB = Convert.ToDouble(userInput);
            }

            //user calculator methods and output
            var calculate = new Calculator();
            Console.WriteLine("Addition: " + valueA + " + " + valueB + " = " + calculate.Add(valueA, valueB));
            Console.WriteLine("Subtraction: " + valueA + " - " + valueB + " = " + calculate.Subtract(valueA, valueB));     
            Console.WriteLine("Multiplication: " + valueA + " * " + valueB + " = " + calculate.Multiple(valueA, valueB));
            
            //check if value b = 0, that output division error
            if(valueB == 0)
            {
                Console.WriteLine("Division Error");
            }
            else
            {
                Console.WriteLine("Division: " + valueA + " / " + valueB + " = " + calculate.Divide(valueA, valueB));
            }
    
        }//end of static 

        //check user Input function, output bool return
        static bool checkInput(string userInput)
        {
            var s = userInput.Length;
            var point = 0;
            for (int i = 1; i < s; ++i)
            {
                if (userInput[i] != '.' && (userInput[i] > '9' || userInput[i] < '0'))
                {
                    return false;
                }
                if (userInput[i] == '.')
                {
                    ++point;
                }
            }
            if (point > 1)
            {
                return false;
            }
            return true;
        }
    
        //Calculator Methods:
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
