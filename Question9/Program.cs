DateTime[] DOB = new DateTime[2];
var today = DateTime.Now;

Console.WriteLine("Enter 10 passenger Date of Birth");
for(int i = 0;i < DOB.Length; i++)
{
    Console.Write("Enter DOB : ");
    DOB[i] = DateTime.Parse(Console.ReadLine());
}

for(int i = 0;i < DOB.Length; i++)
{
    var days = (DOB[i]-today).Days;
    var age = days / 365;
    //Console.WriteLine(age);\

    if(age <= 10)
    {
        Console.WriteLine($"Age is {age}. This is a kid.");
    }
    else if(age > 10 && age <= 30)
    {
        Console.WriteLine($"Age is {age}. This is a Youth.");
    }
    else if (age > 30 && age <= 60)
    {
        Console.WriteLine($"Age is {age}. This is an Adult.");
    }
    else
    {
        Console.WriteLine($"Age is {age}. This ia an Old Person.");
    }
}


