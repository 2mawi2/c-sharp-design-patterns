using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace DesignPatterns
{
    public class Client
    {
        public Client()
        {
            var blackboard = new Blackboard();
            var controller = new Controller(blackboard);
        }
    }

    public class Blackboard
    {
        public int Something { get; set; }
    }

    public class Controller
    {
        List<IKnowledgeSource> KnowledgeSources = new List<IKnowledgeSource>();

        public Controller(Blackboard blackboard)
        {
            KnowledgeSources.Add(new KnowledgeSource());
            KnowledgeSources = KnowledgeSources.OrderBy(i => i.Priority).ToList();
            KnowledgeSources.ForEach(i => i.Configure(blackboard));

            for (var j = 0; j < 1000; j++) // repeat 1000 times
            {
                KnowledgeSources.ForEach(i => i.ExecuteAction());
            }
        }
    }

    public class KnowledgeSource : IKnowledgeSource
    {
        private Blackboard _blackboard;
        public int Priority { get; set; } = 0;

        public void Configure(Blackboard blackboard)
        {
            _blackboard = blackboard;
        }

        public void ExecuteAction()
        {
            _blackboard.Something = 1;
        }
    }

    public interface IKnowledgeSource
    {
        int Priority { get; set; }
        void Configure(Blackboard blackboard);
        void ExecuteAction();
    }
}