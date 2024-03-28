public class Upper_Decorator : Decorator<string>
{
    public Upper_Decorator(Deco_Interface<string> component) : base(component) { }
    public override string GetText()
    {
        return base.GetText().ToUpper();
    }
}
