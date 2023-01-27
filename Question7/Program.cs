Console.Write("Enter Name of Passenger : ");
string name = Console.ReadLine();

Console.Write("Enter the total miles travelled : ");
int miles= int.Parse(Console.ReadLine());

int award = 0;
if(miles > 10000 && miles < 20000)
{
    award = award + 10;
    Console.WriteLine("Awarded 10 flyer points ");
}
else if(miles > 20000 && miles < 50000)
{
    award = award + 20;
    Console.WriteLine("Awarded 20 flyer points ");
}
else if(miles > 50000 && miles < 100000)
{
    award = award + 30;
    Console.WriteLine("Awarded 30 flyer points ");
}
else if(miles >= 100000)
{
    award = award + 50;
    Console.WriteLine("Awarded 50 flyer points ");
}