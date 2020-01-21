using System;
using Xunit;
using Xunit.Abstractions;
using XUnitTest.Model;

namespace XUnitTest.Test
{
    public class CalculateTest:IClassFixture<CalculateFixture>
    {
        private readonly ITestOutputHelper testOutput;
        private readonly CalculateFixture calculateFixture;

        public CalculateTest(ITestOutputHelper testOutput,CalculateFixture calculateFixture)
        {
            this.testOutput = testOutput;
            this.calculateFixture = calculateFixture;
        }
        [Fact]
        [Trait("Title","Sum")]
        public void Should_Return3When_Sum2And1()
        {
            calculateFixture.calculator.Sum(2, 1);
            Assert.Equal(3, calculateFixture.calculator.Result);
            testOutput.WriteLine(DateTime.Now.ToString());
        }
        [Fact]
        [Trait("Title","Sub")]
        public void Should_Return2_When_Sub4And2()
        {
            calculateFixture.calculator.Sub(4, 2);
            Assert.Equal(2, calculateFixture.calculator.Result);
            testOutput.WriteLine(DateTime.Now.ToString());

        }
    }
}
