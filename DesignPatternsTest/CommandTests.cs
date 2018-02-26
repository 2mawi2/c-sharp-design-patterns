using System.Runtime.InteropServices.ComTypes;
using DesignPatterns;
using FluentAssertions;
using Xunit;

namespace DesignPatternsTest
{
    public class CommandTest
    {
        [Fact]
        public void CommandPatternTest()
        {
            var subject = new Subject {First = 1, Second = 2};
            var invoker = new Invoker();

            invoker.Commands.Add(new AddCommand(subject));
            invoker.Execute();

            subject.Result.Should().Be(3);

            invoker.Commands.Add(new SubstractCommand(subject));
            invoker.Execute();

            subject.Result.Should().Be(-1);
        }
    }
}