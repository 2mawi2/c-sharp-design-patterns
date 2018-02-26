using System.Runtime.InteropServices.ComTypes;
using DesignPatterns;
using Moq;
using Xunit;

namespace DesignPatternsTest
{
    public class SingletonTests
    {
        [Fact]
        public void SingletonTest()
        {
            var singleton = Singleton.Instance;
            Assert.NotNull(singleton);
        }
    }
}