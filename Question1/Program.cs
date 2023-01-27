string?[] passengerNames = new string[4]; //{"John Doe", "Jane Doe", "Janet Doe", "John Doe" };

for (int i = 0; i < passengerNames.Length; i++)
{
    Console.WriteLine($"Enter the name of person {i + 1}:");
    passengerNames[i] = Console.ReadLine();
}

Console.WriteLine();
Console.WriteLine("Passanger Names");
for (int i = 0; i < passengerNames.Length; i++)
{
    Console.WriteLine($"Name of  Passenger {i + 1} : {passengerNames[i]}");
}

Console.WriteLine("\n\nPassenger names in Alphabetic Order");
Array.Sort(passengerNames);
for (int i = 0; i < passengerNames.Length; i++)
{
    Console.WriteLine("Passenger : " + passengerNames[i]);
}

Console.WriteLine("\n\nPassenger Names in Reverse Alphabetic Order");
Array.Reverse(passengerNames);


for (int i = 0; i < passengerNames.Length; i++)
{
    Console.WriteLine("Passenger : " + passengerNames[i]);
}

Console.WriteLine("\n\nEnter a Passenger Name to Search ");
string search = Console.ReadLine();
var result = Array.Find(passengerNames, element => element == search);

if (result != null)
{
    Console.WriteLine("Result Found " + result);
}
else
{
    Console.WriteLine("Result not found");
}

Console.WriteLine("\n\nLength of Each Passenger name");

for (int i = 0; i < passengerNames.Length; i++)
{
    Console.WriteLine("Lenght of " + passengerNames[i] + " :: " + passengerNames[i].Length);
}

Console.WriteLine();
Console.WriteLine("Displaying First Name and Last Name: ");
foreach (var name in passengerNames)
{
    var splittedNames = name.Split(' ');
    Console.WriteLine($"First Name: {splittedNames[0]} Last Name: {splittedNames[1]}");
}

Console.WriteLine("\n\nPrinting Duplicate Entries");

for (int i = 0; i < passengerNames.Length; i++)
{
    int count = 1;
    for (int j = i + 1; j < passengerNames.Length; j++)
    {
        if (passengerNames[i] == passengerNames[j])
        {
            count++;
        }
    }
    if (count > 1)
    {
        Console.WriteLine(passengerNames[i]);
    }
}

//Console.ReadKey();