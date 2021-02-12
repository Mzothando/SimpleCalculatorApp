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
    }
}
