var PassengerList = new List<string>();
var DestinationList = new List<string>(); while (true)
{
    Console.WriteLine("1 Enter Passenger Name and Destination");
    Console.WriteLine("2 Exit");
    Console.WriteLine("\n");
    int choice = int.Parse(Console.ReadLine());
    Console.WriteLine("\n");
    if (choice == 1)
    {
        Console.Write("Enter Passenger Name => ");
        PassengerList.Add(Console.ReadLine());
        Console.Write("Enter Passenger Destination => ");
        DestinationList.Add(Console.ReadLine());
        Console.WriteLine("\n");
    }
    else if (choice == 2)
    {
        break;
    }
}
int ArrayLength = PassengerList.Count; string[] CombinedArray = new string[ArrayLength]; for (int i = 0; i < CombinedArray.Length; i++)
{
    CombinedArray[i] = PassengerList[i] + " : " + DestinationList[i];
}
foreach (var item in CombinedArray)
{
    Console.WriteLine(item);
}