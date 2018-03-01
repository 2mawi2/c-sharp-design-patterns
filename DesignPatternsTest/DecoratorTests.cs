using System.Runtime.InteropServices.ComTypes;
using DesignPatterns;
using FluentAssertions;
using Xunit;

namespace DesignPatternsTest
{
    public class DecoratorTest
    {
        [Fact]
        public void CommandPatternTest()
        {
            var target = new Target();
            target.DoSth();

            var targetDecorated = new ConcreteDecorator(target);
            targetDecorated.DoSth();
            targetDecorated.DoSthElse();

            var targetDecoratedAgain = new ConcreteSecondLevelDecorator(targetDecorated);
            targetDecoratedAgain.DoSth();
            targetDecoratedAgain.DoSthElse();
            targetDecoratedAgain.DoSthCompletelyElse();
        }
    }
}