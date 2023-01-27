Console.WriteLine("Enter 10 Flight Fares");
decimal[] fare = new decimal[4];

for(int i = 0;i < 4; i++)
{
    Console.Write($"Enter Fare {i+1} : ");
    fare[i] = decimal.Parse(Console.ReadLine());
}

Console.WriteLine();

Console.Write("Ascending Order of Flight Fare : ");

for(int i = 0;i < fare.Length; i++)
{
    for (int j = i+1; j < fare.Length; j++)
    {
        if (fare[i] > fare[j])
        {
            decimal temp = fare[i];
            fare[i] = fare[j];
            fare[j] = temp;
        }
    }
}

Console.WriteLine(string.Join(", ", fare));

Console.WriteLine();

Console.Write("Descenting Order of Flight Fare : ");

for (int i = 0; i < fare.Length; i++)
{
    for (int j = i + 1; j < fare.Length; j++)
    {
        if (fare[i] < fare[j])
        {
            decimal temp = fare[i];
            fare[i] = fare[j];
            fare[j] = temp;
        }
    }
}

Console.WriteLine(string.Join(", ", fare));

Console.WriteLine();

Console.Write("Enter a fare to search :");
decimal search = decimal.Parse(Console.ReadLine());
var result = Array.Find(fare, element => element.Equals(search));

if (result != null)
{
    Console.WriteLine("Result Found " + result);
}
else
{
    Console.WriteLine("Result not found");
}

Console.WriteLine();

Console.WriteLine("Maximum and Minimum Values");
decimal max = fare.Max();
Console.WriteLine($"Maximum Fare :: {max}");

decimal min = fare.Min();
Console.WriteLine($"Minimum Fare :: {min}");

Console.WriteLine();

Console.WriteLine("Duplicate Values ");

for (int i = 0; i < fare.Length; i++)
{
    int count = 1;
    for (int j = i+1; j < fare.Length; j++)
    {
        if (fare[i] == fare[j])
        {
            count++;
        }
    }
    if(count > 1)
    {
        Console.WriteLine(fare[i]);
    }
}
