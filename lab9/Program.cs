using lab9;
lab9.LinkedList<double> list = new lab9.LinkedList<double>();
list.Add(-96);
list.Add(1);
list.Add(-2);
list.Add(4);
foreach (var item in list) 
{
    Console.Write(item+" ");
}
Console.WriteLine();
int i = 0;
foreach (var item in list)
{
    if (item > 0)
    {
        i++;
        if (i == 1)
        {
            list.Add(item);
        Console.Write(item + " ");
        }
        else Console.Write(item + " ");
    }
    else Console.Write(item + " ");
    
}
Console.WriteLine();