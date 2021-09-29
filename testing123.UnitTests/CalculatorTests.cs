using System;
using Xunit;

namespace testing123.UnitTests
{
    public class CalculatorTests
    {
        [Fact]
        public void AddTest()
        {
            Assert.Equal(4, new Calculator().Add(2, 2));
        }
    }
}
