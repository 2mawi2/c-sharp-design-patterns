using System.Collections.Generic;
using DesignPatterns;
using Moq;
using Xunit;

namespace DesignPatternsTest
{
    public class ObserverTest
    {
        [Fact]
        public void ObservableShouldUpdateAllObservers()
        {
            var observerMocks = new List<Mock<IObserver>>
            {
                new Mock<IObserver>(),
                new Mock<IObserver>(),
                new Mock<IObserver>(),
            };
            var observable = new Observable();
            observerMocks.ForEach(i => observable.Subscribe(i.Object));

            observable.OnEvent();

            observerMocks.ForEach(i => i.Verify(j => j.Update()));
        }
    }
}