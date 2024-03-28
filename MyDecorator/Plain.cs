public class Plain_Decorator : Decorator<string>
{
    public Plain_Decorator(Deco_Interface<string> component) : base(component) { }

    public override string GetText()
    {
        return base.GetText();
    }
}
