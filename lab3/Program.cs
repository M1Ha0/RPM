using lab3;

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


