using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    public class Observable
    {
        private readonly List<IObserver> _observers = new List<IObserver>();

        public void Subscribe(IObserver observer) => _observers.Add(observer);
        public void UnSubscribe(IObserver observer) => _observers.Remove(observer);

        public void OnEvent()
        {
            Console.WriteLine("Handling Event");

            NotifyObservers();
        }

        private void NotifyObservers() => _observers.ForEach(i => i.Update());
    }

    public class Observer : IObserver
    {
        public void Update() => Console.WriteLine("Updated");
    }

    public interface IObserver
    {
        void Update();
    }
}