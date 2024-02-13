using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(3, 4, 6, 13)]
        [InlineData(5, 5, 5, 15)]
        [InlineData(11, 11, 11, 33)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            Calculator myCalc = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = myCalc.Add(num1, num2, num3);
            //Assert
            //Assert.Equal(expected, actual);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 2, 3)]//Add test data <-------
        [InlineData(7, 1, 6)]
        [InlineData(12, 3, 9)]
        [InlineData(5, 7, -2)]
        [InlineData(4, 4, 0)]
        public void SubtractTest(int minuend, int subtrahend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            Calculator calc = new Calculator();

            //Act
            var actual = calc.Subtract(minuend, subtrahend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 3, 6)]//Add test data <-------
        [InlineData(3, 5, 15)]
        [InlineData(3, 3, 9)]
        [InlineData(-2, 3, -6)]
        [InlineData(5, 5, 25)]
        [InlineData(11, 4, 44)]
        [InlineData(3, 12, 36)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            Calculator calc = new Calculator();
            //Act
            var actual = calc.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 2, 2)]//Add test data <-------
        [InlineData(9, 3, 3)]
        [InlineData(12, 6, 2)]
        [InlineData(25, 5, 5)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            Calculator calc = new Calculator();
            //Act
            var actual = calc.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
