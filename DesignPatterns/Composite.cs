using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    public interface IComposite
    {
        void Update();
    }

    public class Composite : IComposite
    {
        public readonly List<IComposite> Childs = new List<IComposite>();

        public void Update() => Childs.ForEach(i => i.Update());
    }

    public class Leaf : IComposite
    {
        public void Update() => Console.WriteLine("Got Updated");
    }
}