Console.Write("Введите число n:");
int n = int.Parse(Console.ReadLine()!);
List<int> list = new List<int>();
Random random = new Random();
for (int i = 0; i < n; i++)
{
    list.Add(random.Next(0,100));
    Console.Write($"{list[i]} ");
}
Console.WriteLine();
int prois = 1;
foreach (int num in list)
{
    if (num % 2 == 0)
    {
        prois *= num;
    }
}
Console.WriteLine($"Произведение четных элементов: {prois}");