using Shop.Utils;
using System;
using Xunit;

namespace Shop.Utils
{
    public class UnitTest1
    {
        [Fact]
        public void MatUtilTests()
        {
            MatUtil m = new MatUtil();

            var result = m.Factorial(1);

            Assert.Equal(1, result);
        }
    }
}
