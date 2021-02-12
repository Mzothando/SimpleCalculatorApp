using SimpleCalculatorApp.Library.Services;
using System;

namespace SimpleCalculatorApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Input 1st number");
            var firsNumber = Console.ReadLine();

            Console.WriteLine("Please Input 2nd number");
            var secodNumber = Console.ReadLine();

            Console.WriteLine("Please Input the arithmetic Operator (+, -, * OR /)");
            var Operator = Console.ReadLine();

            var simpleCalc = new SimpleCalculatorService();

            var results = simpleCalc.Compute(int.Parse(firsNumber), int.Parse(secodNumber), Operator);

            Console.WriteLine(results);
            





        }
    }
}
