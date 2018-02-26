namespace DesignPatterns
{
    public interface IUiElement
    {
    }

    public class Button : IUiElement
    {
    }

    public class Window : IUiElement
    {
    }

    /**
     * Anti-Pattern -> Use dependency injection instead if possible
     */
    public interface IUiElementFactory
    {
        IUiElement Create();
    }

    public class ButtonFactory : IUiElementFactory
    {
        public IUiElement Create() => new Button();
    }

    public class WindowFactory : IUiElementFactory
    {
        public IUiElement Create() => new Window();
    }
}