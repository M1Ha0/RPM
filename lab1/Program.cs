Console.Write("Введите ежемесячную стипендию:");
double sipendia = double.Parse(Console.ReadLine()!);
Student student = new Student()
{
    Surname = "Иванов",
    Name = "Арсений",
    Patronymic = "Олегович",
    Sipendia = sipendia
};
Console.WriteLine(student);

Console.Write("Введите зарплату:");
double oklad = double.Parse(Console.ReadLine()!);
Console.Write("Введите процентную ставку:");
int stavka = int.Parse(Console.ReadLine()!);
Employee employee = new Employee
{
    Surname = "Иванов",
    Name = "Олег",
    Patronymic = "Петрвич",
    Oklad = oklad,
    Stavka = stavka
};
Console.WriteLine(employee);
abstract class Person
{
    public string? Surname { get; set; }
    public string? Name { get; set; }
    public string? Patronymic { get; set; }
    public abstract double Income();
}
class Student : Person
{
    public double Sipendia { get; set; }
    public override double Income() => Sipendia * 12;
    public override string? ToString()
    {
        return $"Годовой доход:{Income():F2}";
    }
}
class Employee : Person
{
    public double Oklad { get; set; }
    public int Stavka { get; set; }
    public override double Income() => (Oklad * 12)-(((Oklad * 12)/100)* Stavka);
    public override string? ToString()
    {
        return $"Годовой доход:{Income():F2}";
    }
}
