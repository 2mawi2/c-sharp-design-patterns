using System.Runtime.InteropServices.ComTypes;
using DesignPatterns;
using FluentAssertions;
using Moq;
using Xunit;

namespace DesignPatternsTest
{
    public class AdapterTest
    {
        [Fact]
        public void CommandPatternTest()
        {
            var adaptee = new Mock<IAdaptee>();
            var adapter = new Adapter(adaptee.Object);

            adapter.BeautifulMethod();

            adaptee.Verify(i => i.Authenticate());
            adaptee.Verify(i => i.FarTooLongSignatureOfMethodWhichShouldGetWrapped());
        }
    }
}