namespace LearningInterfaces3.Entities;
public class Scanner : Device, IScanner
{
    public override void ProcessDoc(string document)
    {
        System.Console.WriteLine("Scanner processing: " + document);
    }

    public string Scan()
    {
        return "Scanner scan result";
    }

}
