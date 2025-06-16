using static System.Runtime.InteropServices.JavaScript.JSType;

Znak<int>[] mas = new Znak<int>[3];
for (int i = 0; i < mas.Length; i++)
{
    Console.Write("Фамилия и имя: ");
    string fullName = Console.ReadLine()!;
    Console.Write("Знак Зодиака: ");
    string zodiac = Console.ReadLine()!;
    Console.Write("Идентификационный номер: ");
    int number = int.Parse(Console.ReadLine()!);

    Console.WriteLine("Дата рождения (день месяц год):");
    int[] date = new int[3];
    Console.Write("День: ");
    date[0] = int.Parse(Console.ReadLine()!);
    Console.Write("Месяц: ");
    date[1] = int.Parse(Console.ReadLine()!);
    Console.Write("Год: ");
    date[2] = int.Parse(Console.ReadLine()!);

    mas[i] = new Znak<int>(fullName, zodiac, number, date);
}
Array.Sort(mas);
foreach (var item in mas)
{
    Console.WriteLine(item);
}
Console.WriteLine();
Array.Sort(mas, new SortBy());
foreach (var item in mas)
{
    Console.WriteLine(item);
}
class Znak<T> : ICloneable, IComparable
{
    public string? FullName { get; set; }
    public string? Zodiak { get; set; }
    public T Number { get; set; }
    public int[] Date { get; set; }

    public Znak(string? fullName, string? zodiak, T number, int[] date)
    {
        FullName = fullName;
        Zodiak = zodiak;
        Number = number;
        Date = date;
    }
    public override string? ToString()
    {
        return $"Фамилия, имя:{FullName}, знак Зодиака:{Zodiak}," +
            $"идентификационный номер :{Number}, дата рождения {Date[0]},{Date[1]},{Date[2]}";
    }
    public object Clone() => new Znak<T>(FullName, Zodiak, Number, Date);
    public int CompareTo(object? obj)
    {
        if (obj is Znak<int> value)
        {
            int year = Date[2].CompareTo(value.Date[2]);
            if (year != 0) return year;
            int month = Date[1].CompareTo(value.Date[1]);
            if (month != 0) return month;
            return Date[0].CompareTo(value.Date[0]);
        }
        else throw new ArgumentException("Некорректное значение параметра");
    }
}
class SortBy : System.Collections.IComparer
{
    public int Compare(object? x, object? y)
    {
        if (x is Znak<int> xPerson && y is Znak<int> yPerson)
        {
            return string.Compare(xPerson.FullName, yPerson.FullName);
        }
        else throw new ArgumentException("Некорректное значение параметра");
    }
}