namespace MyDecorator;
class Program
{
    static void Main()
    {
        Deco_Interface<string> component = new ConcreteComponent();

        var plainText = new PlainDecorator(component);
        var upperText = new UpperCaseDecorator(component);
        var colorText = new ColorDecorator(component);

        Console.WriteLine(plainText.GetText());
        Console.WriteLine(upperText.GetText());
        Console.WriteLine(colorText.GetText());
    }
}
