public class UpperCaseDecorator : Decorator<string>
{
    public UpperCaseDecorator(Deco_Interface<string> component) : base(component) { }

    public override string GetText()
    {
        return base.GetText().ToUpper();
    }
}
