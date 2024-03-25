// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

class Program
{
    public Program()
    {
    }

    static void Main()
    {
        Deco_Interface<string> component = new ConcreteComponent();
        var plainDecorator = new PlainDecorator(component);
        var upperCaseDecorator = new UpperCaseDecorator(component);
        var colorDecorator = new ColorDecorator(component);

        Console.WriteLine(plainDecorator.GetText());
        Console.WriteLine(upperCaseDecorator.GetText());
        Console.WriteLine(colorDecorator.GetText());
    }
}

