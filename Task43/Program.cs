// See https://aka.ms/new-console-template for more information
Console.Clear();
void Point(double a, double b, double c, double d)
{
    if(a==c)
    {
        Console.WriteLine("Прямые параллельны");
    }
    else
    {
        double X =(d-b)/(a-c);
        double Y =a*X+b;
        Console.WriteLine("Точка пересечения прямой у="+a+"x+"+b+" и прямой у="+c+"x+"+d+": ("+X+";"+Y+")");
    }
}
Console.WriteLine("Введите угловой коэффициент К первой прямой: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите свободный член В первой прямой: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите угловой коэффициент К второй прямой: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите свободный член В второй прямой: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Point(k1,b1,k2,b2);
