using System.Runtime.InteropServices.ComTypes;
using DesignPatterns;
using FluentAssertions;
using Moq;
using Xunit;

namespace DesignPatternsTest
{
    public class ChainOfResponsibilityTest
    {
        Mock<ILogger> MockLogger = new Mock<ILogger>();

        [Fact]
        public void ChainOfResponsibility_OneHandler()
        {
            const int loglevel = 3;
            var secondLogHandler = new SecondConcreteLogHandler(MockLogger.Object);
            var firstLogHandler = new FirstConcreteLogHandler(MockLogger.Object, secondLogHandler);

            firstLogHandler.DoSth(loglevel);

            MockLogger.Verify(i => i.Log(), Times.Exactly(1));
        }

        [Fact]
        public void ChainOfResponsibility_TwoHandler()
        {
            const int loglevel = 6;
            var secondLogHandler = new SecondConcreteLogHandler(MockLogger.Object);
            var firstLogHandler = new FirstConcreteLogHandler(MockLogger.Object, secondLogHandler);

            firstLogHandler.DoSth(loglevel);

            MockLogger.Verify(i => i.Log(), Times.Exactly(2));
        }
    }
}