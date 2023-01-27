int weightDiff;

string[] boardPass = new string[3];
int[] weight = new int[3];
int[] weightDIffArray = new int[weight.Length];

for (int i = 0; i < boardPass.Length; i++)
{
    Console.WriteLine("enter your name");
    string name = Console.ReadLine();
    boardPass[i] = name;
    Console.WriteLine("weigth");
    int weightElement = Convert.ToInt32(Console.ReadLine());
    weight[i] = weightElement;


}

Console.WriteLine("\n");
for (int i = 0; i < boardPass.Length; i++)
{

    Console.WriteLine("name-{0}", boardPass[i]);
    Console.WriteLine("weight-{0}kg", weight[i]);
    Console.WriteLine($"weigth charge {weightFun(weight[i])}$");
    weightDIffArray[i] = weightFun(weight[i]);
    Console.WriteLine("\n");
}

int weightFun(int weight)
{
    int weightDiffInFun = (weight - 23);
    if (weightDiffInFun > 0)
    {
        return (20 + (weightDiffInFun * 15));
    }
    else
    {
        return 20;
    }
}

Console.WriteLine("Descending Overweight fare");
Array.Sort(weightDIffArray);
for (int i = (weightDIffArray.Length - 1); i >= 0; i--)
{
    Console.WriteLine($"{weightDIffArray[i]}$");
}