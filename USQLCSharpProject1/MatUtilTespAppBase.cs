using Microsoft.AspNetCore.Mvc;
using UnitTestApp.Controllers;
using Xunit;

namespace Shop.Utils
{
    public class MatUtilTespAppBase
    {
        [Fact]
        public void FactorialTest()
        {
            MatUtil m = new MatUtil();

            var result = m.Factorial(1);

            Assert.Equal(1, result);

        }
    }
}