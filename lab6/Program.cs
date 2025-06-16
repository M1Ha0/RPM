
    double[] x = { 1, 3, 4, 3, 1, 0 };
    double[] y = { 0, 2, 0, -2, -2, 0 }; 

    CalcTriangleArea areaCalculator = delegate (double x1, double y1, double x2, double y2, double x3, double y3)
    {
        return (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) / 2;
    };

    double area1 = areaCalculator(x[0], y[0], x[1], y[1], x[2], y[2]);
    double area2 = areaCalculator(x[0], y[0], x[2], y[2], x[3], y[3]); 
    double area3 = areaCalculator(x[0], y[0], x[3], y[3], x[4], y[4]);
    double area4 = areaCalculator(x[0], y[0], x[4], y[4], x[5], y[5]); 

    double totalArea = area1 + area2 + area3 + area4;
    Console.WriteLine($"Площадь шестиугольника: {totalArea}");

delegate double CalcTriangleArea(double x1, double y1, double x2, double y2, double x3, double y3);