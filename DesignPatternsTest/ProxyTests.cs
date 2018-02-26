using System.Runtime.InteropServices.ComTypes;
using DesignPatterns;
using FluentAssertions;
using Moq;
using Xunit;

namespace DesignPatternsTest
{
    public class ProxyTests
    {
        [Fact]
        public void ProxyTest()
        {
            var proxy = new ApiProxy();

            proxy.DoSth().Should().Be("proxy");
        }
    }
}