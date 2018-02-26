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

            var targetDecoratedAgain = new AnotherConcreteDecorator(targetDecorated);
            targetDecoratedAgain.DoSth();
            //targetDecoratedAgain.DoSthElse(); This does only work in non-statically typed languages
            targetDecoratedAgain.DoSthCompletelyDifferent();
        }
    }
}