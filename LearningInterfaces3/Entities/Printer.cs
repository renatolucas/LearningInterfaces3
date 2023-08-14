namespace LearningInterfaces3.Entities;
public class Printer : Device, IPrinter
{
    public override void ProcessDoc(string document)
    {
        System.Console.WriteLine("Printer processing: " + document);
    }

    public void Print(string document)
    {
        System.Console.WriteLine("Printer print " + document);
    }

}
