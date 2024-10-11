

Console.Write("Введите a: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите c: ");
double c = Convert.ToDouble(Console.ReadLine());

double d;
double x;
double x1;
double x2;
double xi;

if (a == 0)
{
    if (b == 0)
    {
        if (c == 0)
        {
            Console.Write("Решений бесконечно много");
        }
        else
        {
            Console.Write("Решений нет");
        }
    }
    else
    {
        x = -c / b;
        Console.Write("x=", x);
    }
}
else
{
    d = b * b - 4 * a * c;

    if (d >= 0.00000001)
	{
        x1 = (-b - Math.Sqrt(d)) / (2 * a);
        x2 = (-b + Math.Sqrt(d)) / (2 * a);
        Console.Write($"x1={x1}, x2={x2}");
    }

    else if (d <= 0.00000001)
    {
        x = (-b) / (2 * a);
        xi = (Math.Sqrt(-d)) / (2 * a);
        Console.Write($"x1={x}-{xi}*i, x2={x}+{xi}*i");
    }

    else
    {
        x1 = (-b) / (2 * a);
        Console.Write($"x1={x1}");
    }
}