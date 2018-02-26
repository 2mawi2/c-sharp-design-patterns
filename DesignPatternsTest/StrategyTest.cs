using DesignPatterns;
using FluentAssertions;
using Xunit;

namespace DesignPatternsTest
{
    public class StrategyTest
    {
        [Fact]
        public void StategyPatternTest()
        {
            var context = new StrategyContext(new AddStrategy());

            context.DoSth(1, 2).Should().Be(3);
        }

        [Fact]
        public void StategyPatternTest_Functional()
        {
            var context = new FunctionalStrategyContext((first, second) => first + second);

            context.DoSth(1, 2).Should().Be(3);
        }
    }
}