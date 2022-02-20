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
            //m = MatUtil();

            var result = MatUtil.Factorial(1);
            Assert.Equal(1, result);

            
            Assert.Equal(1, MatUtil.Factorial(1));
            Assert.Equal(2, MatUtil.Factorial(2));
            Assert.Equal(6, MatUtil.Factorial(3));
            Assert.Equal(24, MatUtil.Factorial(4));
            Assert.Equal(87178291200, MatUtil.Factorial(14));
        }
    }
}
