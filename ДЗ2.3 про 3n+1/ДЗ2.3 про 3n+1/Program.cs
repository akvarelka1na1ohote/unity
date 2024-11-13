// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

public int Func(int n)
{
    if (n == 1) return 0;
    else
    {
        int a = 0;
        while (n!=1)
        {
            if (n %2 == 0)
            {
                n = n / 2;
                a = a + 1;
            }
            else
            {
                n = 3 * n + 1;
                a = a + 1;
            }
        }
        return a;
    }
}
