using System;
using Packt;
using Xunit;

namespace CalculatorTests
{
    public class CalculatorUnitTests
    {
        [Fact]
        public void TestAdding2and2()
        {
            //arrange
            double a = 2;
            double b = 2;
            double expected = 4.0;
            CalculatorLib calc = new();

            //  act
            double actual = calc.Add(a, b);

            //assert
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void TestAdding2and3()
        {
            //arrange
            double a = 2.0;
            double b = 3.0;
            double expected = 5.0;
            CalculatorLib calc = new();

            //  act
            double actual = calc.Add(a, b);

            //assert
            Assert.Equal(expected, actual);
        }

    }
}
