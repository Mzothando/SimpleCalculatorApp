using SimpleCalculatorApp.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalculatorApp.Library.Services
{
   public class SimpleCalculatorService : ISimpleCalculatorService
    {
        public int Compute(int firstNumber, int secondNumber, string Operator) // Error (Compute) not all paths return value
        {
            var results = 0;

            if (Operator == "+")
            {
                results = firstNumber + secondNumber;
            }


            if (Operator == "-")
            {
                results = firstNumber - secondNumber;      
            }

            if (Operator == "*")
            {
                results = firstNumber * secondNumber;
            }
            if (Operator == "/")
            {
                results = firstNumber / secondNumber;
            }

            return results;
        }

        private static string[] Operators(string validOperator)
        {
            var supportedOperators = new List<string> { "/", "*", "+", "-" };
            if (validOperator.Contains("supportedOperators") == false)
            {
                throw new ArithmeticException ("errror invalid operator");
                throw new InvalidOperationException("Invalid operator");
            }

            return supportedOperators.ToArray();
        }
    }
}
