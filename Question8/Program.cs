Console.Write("Enter number of elements to add : ");
int numberOfElements = int.Parse(Console.ReadLine());

double[] fare= new double[numberOfElements]; 

string[] destination = new string[numberOfElements];

for (int i = 0;i < numberOfElements; i++)
{
    Console.Write($"Enter Destination {i+1} : ");
    destination[i] = Console.ReadLine();

    Console.Write("Enter Fare : ");
    fare[i] = int.Parse(Console.ReadLine());
}

Console.Write("Enter n'th position to search : ");
int nthPosition = int.Parse(Console.ReadLine());

if(nthPosition > destination.Length || nthPosition > fare.Length)
{
    Console.WriteLine("There is no element in this position.");
}
else
{
    Console.WriteLine($"Destination :: {destination[nthPosition - 1]}");
    Console.WriteLine($"Fare :: {fare[nthPosition - 1]}");
}