public class PlainDecorator : Decorator<string>
{
    public PlainDecorator(Deco_Interface<string> component) : base(component) { }

    public override string GetText()
    {
        return base.GetText();
    }
}
