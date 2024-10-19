//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");



Console.Write("Введите n: ");
double n = Convert.ToDouble(Console.ReadLine());
if (n == 1)
{
    Console.WriteLine("Их нет");
}

else if (n == 2)
{
    Console.WriteLine("2");
}

else if (n == 3)
{
    Console.WriteLine("2");
    Console.WriteLine("3");
}

else if (n > 3)
{
    Console.WriteLine("2");
    Console.WriteLine("3");
    for (int j = 3; j < n; j += 2)
    {
        int a = 0;
        for (int i = 2; i <= Math.Sqrt(j); i += 1)
        {
            if (j % i == 0)
            {
                a += 1;
            }
        }
        if (a == 0)
        {
            Console.WriteLine($"{j}");
        }
    }
}

