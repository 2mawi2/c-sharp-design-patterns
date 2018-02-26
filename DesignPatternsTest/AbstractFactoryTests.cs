using System.Runtime.InteropServices.ComTypes;
using DesignPatterns;
using Moq;
using Xunit;

namespace DesignPatternsTest
{
    public class AbstractFactoryTest
    {
        [Fact]
        public void CommandPatternTest()
        {
            var button = new ButtonFactory().Create();
            Assert.IsType<Button>(button);

            var window = new WindowFactory().Create();
            Assert.IsType<Window>(window);
        }
    }
}