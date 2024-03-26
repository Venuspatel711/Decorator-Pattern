public class ConcreteComponent : Deco_Interface<string>
{
    public string GetText()
    {
        return "Hello,world";
    }
}
