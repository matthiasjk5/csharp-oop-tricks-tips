using OOPExample;
using System;

class Program
{
    static void Main(string[] args)
    {
        var comp = new Desktop("Generic Computer", Desktop.CaseType.Tower);
        //comp.name = "Generic Computer";

        //var comp = new Laptop("Generic Laptop", 1024, 768);

        Console.WriteLine("Computer type - " + comp.GetType());

        var isComputer = comp is Computer;

        Console.WriteLine("Is Computer - " + isComputer);
        Console.WriteLine("Computer name - " + comp.name);
        Console.WriteLine("Computer case - " + comp.caseType);

        comp.TogglePower();
        Console.WriteLine("\nComputer is on - " + comp.isOn);
        
        comp.ToggleSleep();
        Console.WriteLine("\nComputer is sleeping - " + comp.isSleeping);
        
        comp.TogglePower();
        Console.WriteLine("\nComputer is on - " + comp.isOn);


        Console.Read();
    }
}

