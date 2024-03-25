public abstract class Decorator<T> : Deco_Interface<T>
{
    protected Deco_Interface<T> component;

    public Decorator(Deco_Interface<T> component)
    {
        this.component = component;
    }

    public virtual T GetText()
    {
        return component.GetText();
    }
}
