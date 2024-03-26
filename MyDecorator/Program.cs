using System;

class Program
{
   
    static void Main()
    {
        Deco_Interface<string> component = new ConcreteComponent();

        var plainDeco = new PlainDecorator(component);
        var upperCaseDeco = new UpperCaseDecorator(component);
        var colorDeco = new ColorDecorator(component);

        Console.WriteLine(plainDeco.GetText());
        Console.WriteLine(upperCaseDeco.GetText());
        Console.WriteLine(colorDeco.GetText());
    }
}

