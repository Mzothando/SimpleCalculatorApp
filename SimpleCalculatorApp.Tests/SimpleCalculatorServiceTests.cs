using FluentAssertions;
using NUnit.Framework;
using SimpleCalculatorApp.Library.Services;


namespace SimpleCalculatorApp.Tests
{

    [TestFixture]
    public class SimpleCalculatorServiceTests
    {
        [TestCase(5,35, "+", 40)]
        [TestCase(2, 4, "*", 8)]
        [TestCase(38, 20, "-", 18)]
        [TestCase(2, 4, "/", 0)]
        public void Accept_Two_Numbers_And_Operator_Then_Return_Results(int firstNumber, int secondNumber, string Operator, int result) {

            //-----------------------------Arrange--------------------------

            var simpleCalculatorService = new SimpleCalculatorService(); //Error reference from the SimpleCalculatorService needed

            //-----------------------------Act------------------------------

            var actual = simpleCalculatorService.Compute(firstNumber, secondNumber, Operator);

            //-----------------------------Assert---------------------------

            actual.Should().Be(result);  //Error = installed fluentAssertion and added a reference

        }
        [TestCase(0, 16, "+",16)]
        //[TestCase(0, 5, "-", 5)]
        //[TestCase(0, 7, "*", 7)]
        [TestCase(0, 16, "/", 16)]
        public void Given_Empty_First_Number_Should_Return_Only_The_Second_Number(int firstNumber, int secondNumber, string Operator, int results)
        {
            //-----------------------------Arrange--------------------------
            
            var simpleCalculatorService = new SimpleCalculatorService(); 
            
            //-----------------------------Act------------------------------
            var actual = simpleCalculatorService.Compute(firstNumber, secondNumber, Operator);

            //-----------------------------Assert---------------------------
            actual.Should().Be(results);


        }
    }
}