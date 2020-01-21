using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xunit;
using Xunit.Sdk;
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
    public class MyDataAttribute : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            List<object[]> data = new List<object[]>();
            data.Add(new object[] { true, 2 });
            data.Add(new object[] { false, 1 });
            data.Add(new object[] { true, 4 });
            return data;
        }

        [Theory]
        [MyData]
        public void EvenTest01(bool iseven,int number)
        {
            OddEven even = new OddEven();
            even.EvenCheck(number);
            Assert.Equal(iseven, even.IsEven);
        }
    }
}
