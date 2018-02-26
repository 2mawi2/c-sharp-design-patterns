using DesignPatterns;
using FluentAssertions;
using Xunit;

namespace DesignPatternsTest
{
    public class TemplateTest
    {
        [Fact]
        public void TemplatePatternTest_Add()
        {
            var result = new AddTemplate().Calculate(1, 2);

            result.Should().Be(3);
        }

        [Fact]
        public void TemplatePatternTest_Substract()
        {
            var result = new SubstractTemplate().Calculate(1, 2);

            result.Should().Be(-1);
        }
    }
}