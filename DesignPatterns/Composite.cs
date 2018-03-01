using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    #region FirstLevel

    public abstract class FirstLevelComposite
    {
        public abstract void Update();
    }

    public class Composite : FirstLevelComposite
    {
        public readonly List<FirstLevelComposite> Childs = new List<FirstLevelComposite>();

        public override void Update() => Childs.ForEach(i => i.Update());
    }

    public class Leaf : FirstLevelComposite
    {
        public override void Update() => Console.WriteLine("Got Updated");
    }

    #endregion


    #region SecondLevel

    public abstract class SecondComposite : Composite
    {
    }

    public class SecondLevelComposite : SecondComposite
    {
    }

    public class SecondLevelLeaf : Leaf
    {
    }

    #endregion
}