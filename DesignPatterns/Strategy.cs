using System;

namespace DesignPatterns
{
    public class StrategyContext
    {
        private readonly IStrategy _strategy;

        public StrategyContext(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public int DoSth(int first, int second) => _strategy.Execute(first, second);
    }

    public class FunctionalStrategyContext
    {
        private readonly Func<int, int, int> _strategy;

        public FunctionalStrategyContext(Func<int, int, int> strategy)
        {
            _strategy = strategy;
        }

        public int DoSth(int first, int second) => _strategy.Invoke(first, second);
    }

    public interface IStrategy
    {
        int Execute(int first, int second);
    }

    public class AddStrategy : IStrategy
    {
        public int Execute(int first, int second) => first + second;
    }

    public class SubstractStrategy : IStrategy
    {
        public int Execute(int first, int second) => first - second;
    }
}