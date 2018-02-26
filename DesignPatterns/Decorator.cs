using System;

namespace DesignPatterns
{
    public interface ITarget
    {
        void DoSth();
    }

    public class Target : ITarget
    {
        public void DoSth() => Console.WriteLine("This is doing sth");
    }

    public abstract class Decorator : ITarget
    {
        private readonly ITarget _targetImplementation;

        protected Decorator(ITarget targetImplementation) => _targetImplementation = targetImplementation;

        public void DoSth() => _targetImplementation.DoSth();
    }

    public class ConcreteDecorator : Decorator
    {
        public ConcreteDecorator(ITarget targetImplementation) : base(targetImplementation)
        {
        }

        public void DoSthElse() => Console.WriteLine("This is doing sth else");
    }

    public class AnotherConcreteDecorator : Decorator
    {
        public AnotherConcreteDecorator(ITarget targetImplementation) : base(targetImplementation)
        {
        }

        public void DoSthCompletelyDifferent() => Console.WriteLine("This is doing sth completely different");
    }
}