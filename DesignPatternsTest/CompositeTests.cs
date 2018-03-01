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
            var leafs = new List<Mock<FirstLevelComposite>>
            {
                new Mock<FirstLevelComposite>(),
                new Mock<FirstLevelComposite>()
            };
            var secondLevelLeaf = new Mock<SecondLevelLeaf>();
            var composite2 = new Composite
            {
                Childs =
                {
                    leafs[1].Object,
                    new Composite
                    {
                        Childs = {leafs[0].Object}
                    },
                    new SecondLevelComposite
                    {
                        Childs =
                        {
                            secondLevelLeaf.Object
                        }
                    }
                }
            };

            composite2.Update();

            leafs.ForEach(i => i.Verify(j => j.Update()));
            secondLevelLeaf.Verify(i => i.Update());
        }
    }
}