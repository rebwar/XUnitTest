using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using XUnitTest.Model;

namespace XUnitTest.Test
{
    public class OddEvenTest
    {
        [Theory]
        [InlineData(true,2)]
        [InlineData(false,1)]
        public void EvenTest(bool isEven,int number)
        {
            OddEven even = new OddEven();
            even.EvenCheck(number);
            Assert.Equal(isEven, even.IsEven);
        }
    }
}
