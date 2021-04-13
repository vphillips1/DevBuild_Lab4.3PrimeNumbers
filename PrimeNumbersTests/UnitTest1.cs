using Lab4._3PrimeNumbers;
using System;
using Xunit;

namespace PrimeNumbersTests
{
    public class UnitTest1
    {

        [Theory]
        [InlineData(1,2)]
        [InlineData(2,3)]
        [InlineData(6, 13)]
        [InlineData(3,5)]
        [InlineData(4,7)]
        public void PrimeNumberTest1(int num, int expected)
        {
            PrimeNumbers prime = new PrimeNumbers();
            int result = prime.GetPrime(num);
            Assert.Equal(expected, result);

        }

           
    }
}
