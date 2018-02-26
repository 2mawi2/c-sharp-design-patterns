using System;

namespace DesignPatterns
{
    interface IDestination
    {
        void BeautifulMethod();
    }

    public class Adapter : IDestination
    {
        private readonly IAdaptee _adaptee;

        //adaptee should get injected, to allow testability
        public Adapter(IAdaptee adaptee) => _adaptee = adaptee;

        public void BeautifulMethod()
        {
            _adaptee.Authenticate();
            _adaptee.FarTooLongSignatureOfMethodWhichShouldGetWrapped();
        }
    }

    public interface IAdaptee
    {
        void FarTooLongSignatureOfMethodWhichShouldGetWrapped();
        void Authenticate();
    }

    public class Adaptee : IAdaptee
    {
        public void Authenticate() => Console.WriteLine("authenticating");

        public void FarTooLongSignatureOfMethodWhichShouldGetWrapped() => Console.WriteLine("doing sth");
    }
}