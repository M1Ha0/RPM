Stack<int> stack = new Stack<int>();

Console.WriteLine("Введите количество элементов в стеке:");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Введите элементы стека (целые числа):");
for (int i = 0; i < n; i++)
{
    int num = int.Parse(Console.ReadLine());
    stack.Push(num);
}

Console.WriteLine("Содержимое стека");
foreach (int item in stack)
{
    Console.Write(item + " ");
}
int sumEven = 0;
int countEven = 0;

foreach (int num in stack)
{
    if (num % 2 == 0) 
    {
        sumEven += num;
        countEven++;
    }
}

if (countEven > 0)
{
    double average = (double)sumEven / countEven;
    Console.WriteLine($"Среднее арифметическое четных чисел: {average:F2}");
}
else
{
    Console.WriteLine("В стеке нет четных чисел.");
}