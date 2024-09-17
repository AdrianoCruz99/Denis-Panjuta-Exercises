using DP106;

public class Program
{
    static void Main(string[] args)
    {
        var fiat = new Car("uno", "fiat");

        Console.WriteLine("What brand the car is: ");
        fiat.Brand = Console.ReadLine();
        Console.WriteLine("the brand is " + fiat.Brand);
        double exemplo = 1233.44455555;
        Console.WriteLine($"{exemplo:F2}");
    }

}

