var FlightNumbers = new List<string>(); while (true)
{
    Console.WriteLine("1 Enter Flight number");
    Console.WriteLine("2 Display Numbers & Exit");
    int choice = int.Parse(Console.ReadLine());
    Console.WriteLine("\n"); if (choice == 1)
    {
        Console.Write("Enter Flight No => ");
        FlightNumbers.Add(Console.ReadLine());
        Console.WriteLine("\n");
    }
    else if (choice == 2)
    {
        break;
    }
    else
    {
        Console.WriteLine("Invalid Choice");
        Console.WriteLine("\n");
    }
}
Console.WriteLine("\n");
foreach (var item in FlightNumbers)
{
    Console.WriteLine(item);
}