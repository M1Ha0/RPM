int[] numbers = { 1, 2, 3, 4, 5, 6, 14, 24, 15, 16 };
int a = 5; 
int b = 3; 


var resultA = numbers.Select(n => n % 10 == 4 ? n / 2 : n).ToArray();
Console.WriteLine("Результат пункта a): " + string.Join(", ", resultA));


var resultB = numbers.Select(n => n % 2 == 0 ? n * n : n * 2).ToArray();
Console.WriteLine("Результат пункта b): " + string.Join(", ", resultB));


var resultC = numbers.Select((n, index) =>
{
    if (index % 2 == 1)
        return n - b;
    else 
        return n + (n % 2 == 0 ? a : 0);
}).ToArray();
Console.WriteLine("Результат пункта c): " + string.Join(", ", resultC));