using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using DesignPatterns;
using FluentAssertions;
using Moq;
using Xunit;

namespace DesignPatternsTest
{
    public class CompositeTest
    {
        [Fact]
        public void CompositeShouldCallAllLeafUpdates()
        {
            var leafs = new List<Mock<IComposite>> {new Mock<IComposite>(), new Mock<IComposite>()};
            var composite2 = new Composite
            {
                Childs =
                {
                    leafs[1].Object,
                    new Composite
                    {
                        Childs = {leafs[0].Object}
                    }
                }
            };

            composite2.Update();

            leafs.ForEach(i => i.Verify(j => j.Update()));
        }
    }
}