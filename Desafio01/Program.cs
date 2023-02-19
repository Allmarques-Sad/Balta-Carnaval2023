internal class Program
{
    private static void Main(string[] args)
    {
        var phrase = "Hi, this is a text";
        Console.WriteLine($"Caracteres: {phrase.Length}");
        Console.WriteLine($"Palavras: {phrase.Split(' ').Length}");
    }
}

// OUTPUT
// Caracteres: 18
// Palavras: 5