Console.WriteLine("Enter the fare");
float fare = float.Parse(Console.ReadLine());

Console.WriteLine("\n Enter the time in 24 Hours Format");
float time = float.Parse(Console.ReadLine());

float newFare = 0;

if (time > 6 & time < 9)
{
    newFare = fare + (fare * 10 / 100);
    Console.WriteLine("\nfare = "+ newFare);
}
else if (time > 9 & time < 17)
{
    newFare = fare + (fare * 20 / 100);
    Console.WriteLine("\nfare = "+ newFare);
}
else if (time > 17 & time < 23)
{
    newFare = fare + (fare * 7 / 100);
    Console.WriteLine("\nfare = "+ newFare);
}
else if (time < 6)
{
    newFare = fare + (fare * 5 / 100);
    Console.WriteLine("\nfare = "+ newFare);
}