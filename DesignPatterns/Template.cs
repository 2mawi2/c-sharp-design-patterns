namespace DesignPatterns
{
    public abstract class Template
    {
        public int DoCalculation(int first, int second)
        {
            return Calculate(first, second);
        }

        public abstract int Calculate(int first, int second);
    }

    public class AddTemplate : Template
    {
        public override int Calculate(int first, int second) => first + second;
    }

    public class SubstractTemplate : Template
    {
        public override int Calculate(int first, int second) => first - second;
    }
}