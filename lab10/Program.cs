Console.WriteLine("Введите кол. строк");
int n = int.Parse(Console.ReadLine());

HashSet<string> newWords = new HashSet<string>();
Console.WriteLine("Заполните строки");
for (int i = 0; i < n; i++)
{
    string line = Console.ReadLine();
    string[] words = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

    foreach (string word in words)
    {
        newWords.Add(word);
    }
}
Console.WriteLine(newWords.Count);