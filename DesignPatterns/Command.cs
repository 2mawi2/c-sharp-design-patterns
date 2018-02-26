using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace DesignPatterns
{
    public class Subject
    {
        public int First { get; set; }
        public int Second { get; set; }
        public int Result { get; set; }
    }

    public abstract class Command
    {
        protected readonly Subject Subject;
        protected Command(Subject subject) => Subject = subject;
        public abstract void Execute();
    }

    public class AddCommand : Command
    {
        public AddCommand(Subject subject) : base(subject)
        {
        }

        public override void Execute() => Subject.Result = Subject.First + Subject.Second;
    }

    public class SubstractCommand : Command
    {
        public SubstractCommand(Subject subject) : base(subject)
        {
        }

        public override void Execute() => Subject.Result = Subject.First - Subject.Second;
    }

    public class Invoker
    {
        public List<Command> Commands { get; set; } = new List<Command>();

        public void Execute()
        {
            Commands.ToList().ForEach(i => i.Execute());
        }
    }
}