Console.Write("Введите фамилию владельца: ");
string ownerLastName = Console.ReadLine();
Console.Write("Введите номер счета: ");
string accountNumber = Console.ReadLine();
Console.Write("Введите процент ");
int interestRate = int.Parse(Console.ReadLine());
Console.Write("Введите баланс ");
double balanceRubles = double.Parse(Console.ReadLine());

Account account = new Account( ownerLastName,  accountNumber, interestRate,  balanceRubles);

account.Display();
Console.WriteLine("Введите фамилию нового владельца");
string newLastName = Console.ReadLine();
account.ChangeOwner(newLastName);
Console.Write("Введите сумму которую хотите внести: ");
double sum1 = double.Parse(Console.ReadLine());
account += sum1;
Console.Write("Введите сумму которую хотите снять: ");
double sum2 = double.Parse(Console.ReadLine());
account -= sum2;
Console.Write("Начисление процентов");
account++;
account.Display();
public class Account
{
    public string OwnerLastName { get; set; }
    public string AccountNumber { get; set; }
    public int InterestRate { get; set; }
    public double BalanceRubles { get; set; }

    public Account(string ownerLastName, string accountNumber, int interestRate, double balanceRubles)
    {
        OwnerLastName = ownerLastName;
        AccountNumber = accountNumber;
        InterestRate = interestRate;
        BalanceRubles = balanceRubles;
    }

    public static Account operator +(Account account, double value)
    {
        if (value <= 0)
        {
            Console.WriteLine("Сумма должна быть положительной!");
            return account;
        }

        account.BalanceRubles += value;
        Console.WriteLine($"Оператор +: Добавлено {value} руб. Новый баланс: {account.BalanceRubles} руб.");
        return account;
    }
    public static Account operator -(Account account, double value)
    {
        if (value <= 0)
        {
            Console.WriteLine("Сумма должна быть положительной!");
            return account;
        }

        if (value > account.BalanceRubles)
        {
            Console.WriteLine("Оператор -: Недостаточно средств на счете!");
        }
        else
        {
            account.BalanceRubles -= value;
            Console.WriteLine($"Оператор -: Снято {value} руб. Остаток: {account.BalanceRubles} руб.");
        }

        return account;
    }
    public static Account operator ++(Account account)
    {
        double interest = account.BalanceRubles * account.InterestRate / 100;
        account.BalanceRubles += interest;
        Console.WriteLine($"Оператор ++: Начислено {interest} руб. процентов. Новый баланс: {account.BalanceRubles} руб.");
        return account;
    }

    public void ChangeOwner(string newLastName)
    {
        if (newLastName!=null)
        {
            OwnerLastName = newLastName;
            Console.WriteLine($"Владелец изменён на: {OwnerLastName}");
        }
        else
        {
            Console.WriteLine("Фамилия не может быть пустой!");
        }
    }
    public double ToDollars(double rate = 79.0)
    {
        return BalanceRubles / rate;
    }

    public double ToEuros(double rate = 90.0)
    {
        return BalanceRubles / rate;
    }
    
    public void Display()
    {
        Console.WriteLine($"Владелец: {OwnerLastName}");
        Console.WriteLine($"Номер счёта: {AccountNumber}");
        Console.WriteLine($"Процентная ставка: {InterestRate}%");
        Console.WriteLine($"Баланс: {BalanceRubles:F2} руб.");
        Console.WriteLine($"В долларах: {ToDollars():F2} USD");
        Console.WriteLine($"В евро: {ToEuros():F2} EUR");
    }
}

