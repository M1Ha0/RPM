using System;
try
    {
    Random random = new Random();
    double a = random.Next(-10, 10);
    double b = random.Next(-10, 10);

    if (a == 0 && b == 0)
    {
        throw new Exception("Коэффициенты A и B прямой не могут быть одновременно нулевыми");
    }
    double c = random.Next(-10, 10);
    double x = random.Next(-10, 10);
    double y = random.Next(-10, 10);
    double numerator = Math.Abs(a * x + b * y + c);
    double denominator = Math.Sqrt(a * a + b * b);
    double res= numerator / denominator;
        Console.WriteLine($"Расстояние от точки ({x}, {y}) до прямой: {res:F2}");
    }
catch (Exception ex)
    {
        Console.WriteLine($"Ошибка: {ex.Message}");
    }

