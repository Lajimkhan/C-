using System;

public class Vehicle
{
    public decimal Price { get; set; }
    public string Color { get; set; }
    public DateTime RegistrationDate { get; set; }
    public DateTime PurchaseDate { get; set; }
    public string FrameNo { get; set; }
}

public class Program
{
    public static void Main()
    {
        // Creating two objects of Vehicle class
        var vehicle1 = new Vehicle()
        {
            Price = 25000.50m,
            Color = "Red",
            RegistrationDate = new DateTime(2020, 10, 1),
            PurchaseDate = new DateTime(2021, 1, 15),
            FrameNo = "X34RT67"
        };

        var vehicle2 = new Vehicle()
        {
            Price = 31000.75m,
            Color = "Blue",
            RegistrationDate = new DateTime(2019, 5, 20),
            PurchaseDate = new DateTime(2020, 3, 10),
            FrameNo = "Y89KL12"
        };

        // Printing the properties of the first vehicle
        Console.WriteLine("Vehicle 1:");
        Console.WriteLine("Price: {0:C}", vehicle1.Price);
        Console.WriteLine("Color: {0}", vehicle1.Color);
        Console.WriteLine("Registration Date: {0:d}", vehicle1.RegistrationDate);
        Console.WriteLine("Purchase Date: {0:d}", vehicle1.PurchaseDate);
        Console.WriteLine("Frame No: {0}", vehicle1.FrameNo);
        Console.WriteLine();

        // Printing the properties of the second vehicle
        Console.WriteLine("Vehicle 2:");
        Console.WriteLine("Price: {0:C}", vehicle2.Price);
        Console.WriteLine("Color: {0}", vehicle2.Color);
        Console.WriteLine("Registration Date: {0:d}", vehicle2.RegistrationDate);
        Console.WriteLine("Purchase Date: {0:d}", vehicle2.PurchaseDate);
        Console.WriteLine("Frame No: {0}", vehicle2.FrameNo);
        Console.WriteLine();
        Console.ReadKey
    }
}
