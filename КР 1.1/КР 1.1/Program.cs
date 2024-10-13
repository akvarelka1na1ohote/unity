//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Console.Write("Введите x: ");
double x = Convert.ToDouble(Console.ReadLine());

double sm;
double s;

sm = x;
s = x;

for (int i = 3; i < 14; i += 2)
{
    //double s;
    s *= (-1) * (x * x) / (i * (i - 1));
    //double sm;
    sm += s;
}
Console.WriteLine($"Результат  равен {sm}");







