// See https://aka.ms/new-console-template for more information
using System.Xml.Linq;

Console.WriteLine("Hello, World!");



Console.Write("Введите длину массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] number = new int[n];
for (int i = 0; i < number.Length; i++)
{
    number[i] = Convert.ToInt32(Console.ReadLine());
}


public int Func(int n)
{
    for (int i = 0; i < n-1 ; i++)
    {
        for (int j = 0; j < n-1; j++)
        {
            if (number[j] > number[j + 1])
            {
                int a = number[j];
                number[j] = number[j + 1];
                number[j + 1] = a;
            }
        }
    }
}
