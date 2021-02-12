using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalculatorApp.Library.Interfaces
{
    public interface ISimpleCalculatorService
    {
        int Compute(int firstNumber, int secondNumber, string Operator);
    }
}
