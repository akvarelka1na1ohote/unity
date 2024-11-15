using ComplexNumbers;

var z1 = new Complex(1, 0);
var z2 = new Complex(0, 1);



Console.WriteLine(z1);
Console.WriteLine(z2);
Console.WriteLine(Complex.Add(z1, z2));
Console.WriteLine(z1 + z2);
Console.WriteLine(z1.Abs());
Console.WriteLine(Complex.Angle(z1));
Console.Write("Введите степень: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Complex.Degree(z1,n));

Console.ReadKey();