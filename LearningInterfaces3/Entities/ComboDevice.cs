using System;

namespace LearningInterfaces3.Entities;
public class ComboDevice : Device, IScanner, IPrinter //solving diamond problem
{
    public override void ProcessDoc(string document)
    {
        Console.WriteLine("ComboDevice processing "+ document);
    }

    public string Scan()
    {
        return "Combodevice scan result";

    }

    public void Print(string document)
    {
        Console.WriteLine("ComboDevice print " + document);
    }

}
