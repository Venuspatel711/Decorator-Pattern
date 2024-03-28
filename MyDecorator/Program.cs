namespace MyDecorator;
class Program
{
    static void Main()
    {
        Deco_Interface<string> component = new ConcreteComponent();

        var plainText = new Plain_Decorator(component);
        var upperText = new Upper_Decorator(component);
        var colorText = new Color_Decorator(component);

        Console.WriteLine(plainText.GetText());
        Console.WriteLine(upperText.GetText());
        Console.WriteLine(colorText.GetText());
    }
}
