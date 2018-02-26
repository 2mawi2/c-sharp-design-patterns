using System.Collections.Generic;
using DesignPatterns;
using FluentAssertions;
using Xunit;

namespace DesignPatternsTest
{
    public class IteratorTest
    {
        [Fact]
        public void IteratorTest_Iterate()
        {
            var iteratorList = new List<int> {1, 2, 3, 4};
            var iterator = new Iterator<int>(iteratorList);
            var resultList = new List<int>();

            while (iterator.HasNext())
            {
                resultList.Add(iterator.Next());
            }

            resultList.Should().BeEquivalentTo(iteratorList);
        }
    }
}