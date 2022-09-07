/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.WriteLine("Yравнения y = k1 * x + b1, y = k2 * x + b2");
Console.WriteLine("b1 = ?");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("k1 = ?");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("b2 = ?");
double b2 = double.Parse(Console.ReadLine());
Console.WriteLine("k2 = ?");
double k2 = double.Parse(Console.ReadLine());

double x = 0;
double y = 0;

if (k1 == k2)
{
  Console.WriteLine("Прямые паралельны или совпадают.");
}
else
{
  x = (b2-b1)/(k1-k2);
y = k1 * x + b1;

Console.WriteLine($"Точка пересечения двух прямых ({x}; {y})");
}
