using Student2;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Class1 student1 = new Class1("Kirsebærvej 13", "Kirstine");
        Console.WriteLine(student1.ReturnNavnOgAdresse());

    }
}