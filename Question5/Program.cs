Console.Write("Enter the length : ");
int length = int.Parse(Console.ReadLine());

decimal[] fare = new decimal[length];
decimal[] sortedFare = new decimal[length * 2];

for (int i = 0; i < fare.Length; i++)
{
    Console.WriteLine("Enter Flight Fare :: ");
    fare[i] = decimal.Parse(Console.ReadLine());
}

int even = 0;
int odd = 1;

for (int i = 0; i < fare.Length; i++)
{
    if((fare[i] %2) == 0){
        sortedFare[even] = fare[i];
        even += 2;
    }
    else
    {
        sortedFare[odd] = fare[i];
        odd += 2;
    }
}

Console.WriteLine(string.Join(", ", sortedFare));

