using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        string way = "f.txt";

        using (StreamWriter writing = new StreamWriter(way))
        {
            // заголовок "таблицы" (забавно, что в txt))
            writing.WriteLine("x \t sin(x)");

            for (double x = 0.0; x <= 1.0; x += 0.1)
            {
                writing.WriteLine($"{x} \t {Math.Sin(x)}");
            }
        }

        Console.WriteLine($"Таблица значений функции sin(x) была успешно записана в файл {way}.");
    }
}