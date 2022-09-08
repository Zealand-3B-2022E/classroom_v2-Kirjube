using Json_øvelse.Models;
using System.Text.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        // Car car1 = new Car("Nisan","Odessy","Grey",100000);
        Car car2 = new Car();
        car2.Brand = "Nisan";
        car2.Model = "Odessy";
        car2.Color = "Grey";
        car2.Milage = 15000;
        Car car3 = new Car();
        car3.Brand = "Fiat";
        car3.Model = "Punto";
        car3.Color = "Black";
        car3.Milage = 2000;
        Console.WriteLine(car2);

        string car2Json = JsonSerializer.Serialize(car2);

        Console.WriteLine(car2Json);

        List<Car> carList = new List<Car>();
        carList.Add(car2);
        carList.Add(car3);

        string carListJson = JsonSerializer.Serialize(carList);

        Console.WriteLine(carListJson);
        Car car21 = JsonSerializer.Deserialize<Car>(car2Json);
        Console.WriteLine(car21);
        List<Car> carListBackFromJson = JsonSerializer.Deserialize<List<Car>>(carListJson);

        foreach(Car s in carListBackFromJson)
        {
            Console.Write(s);
        }
    }
}