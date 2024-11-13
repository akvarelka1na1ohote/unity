// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// ФИБОНАЧЧИ

// Рекурсивно:
Console.Write("Введите n: ");
double n = Convert.ToDouble(Console.ReadLine());

public int FiboRec(int n)
{
    if (n == 0) return 0;
    else if (n == 1) return 1;
    else
    {
        return FactorialRec(n-1) + FactorialRec(n-2);
    }
}


// Итеративно:
Console.Write("Введите n: ");
double n = Convert.ToDouble(Console.ReadLine());

public int FiboInt(int n)
{
    if (n == 0) return 0;
    if (n == 1) return 1;

    int a = 0, b = 1, c = 0;
    for (int i = 2; i<=n; i++)
    {
        c = a + b;
        a = b;
        b = c;
    }
    return c;
}





// ФАКТОРИАЛ

// Рекурсивно:
Console.Write("Введите n: ");
int n = Convert.ToDouble(Console.ReadLine());

public int FactorialRec(int n)
{
    if ((n == 0) or (n == 1)) return 0;
    else
    {
        return FactorialRec(n - 1)*n;
    }
}


// Итеративно:
Console.Write("Введите n: ");
int n = Convert.ToDouble(Console.ReadLine());

public int FactorialInt(int n)
{
    if ((n == 0) or (n == 1)) return 1;

    int a = 1;
    for (int i = 2; i<=n; i++)
    {
        a = a * i;
    }
    return a;
}


