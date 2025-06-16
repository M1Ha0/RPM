Dictionary<string, Dictionary<string, int>> buyers = new Dictionary<string, Dictionary<string, int>>();

Console.WriteLine("Введите количество записей о покупках:");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Введите записи о покупках (в формате 'Покупатель Товар Количество'):");
for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(' ');
    string buyer = input[0];
    string product = input[1];
    int koll = int.Parse(input[2]);

    if (!buyers.ContainsKey(buyer))
    {
        buyers[buyer] = new Dictionary<string, int>();
    }
    if (buyers[buyer].ContainsKey(product))
    {
        buyers[buyer][product] += koll;
    }
    else
    {
        buyers[buyer][product] = koll;
    }
}

Console.WriteLine("\nРезультат:");
foreach (var buyer in buyers.Keys)
{
    Console.WriteLine($"Покупатель: {buyer}");
    foreach (var product in buyers[buyer].Keys)
    {
        Console.WriteLine($"  Товар: {product}, Количество: {buyers[buyer][product]}");
    }
}