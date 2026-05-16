const string filePath = "file.txt";
var writer = new FilerWriter(filePath);
writer.Write("Some texxt");
Console.WriteLine("Press any key to close");

var reader = new SpecificLineFromTextFileReadder(filePath);
var third = reader.ReadLineNumber(1);

Console.WriteLine($"Press any key to close: {third}");

Console.ReadKey();


// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
public class FilerWriter
{
    private readonly StreamWriter _writer;

    public FilerWriter(string filePath)
    {
        _writer = new StreamWriter(filePath);
    }

    public void Write(string text)
    {
        _writer.WriteLine(text);
        _writer.Flush();
    }
}


public class SpecificLineFromTextFileReadder
{
    private readonly StreamReader _reader;
    public SpecificLineFromTextFileReadder(string filePath)
    {
        _reader = new StreamReader(filePath);
    }

    public string ReadLineNumber(int number)
    {
        for (int i = 0; i < number - 1; i++)
        {
            _reader.ReadLine();
        }

        return _reader.ReadLine();
    }
}