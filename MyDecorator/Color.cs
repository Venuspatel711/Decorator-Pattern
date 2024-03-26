public class ColorDecorator : Decorator<string>
{
    public ColorDecorator(Deco_Interface<string> component) : base(component) { }
    public override string GetText()
    {
        return $"\u001b[45m{base.GetText()}\u001b[0m";
    }
}
