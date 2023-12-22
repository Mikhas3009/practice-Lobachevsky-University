// See https://aka.ms/new-console-template for more information
using nasledovanie_3_;
using System.Drawing;

Console.WriteLine("Hello, World!");
Color color = Color.FromArgb(255, 0, 0);
Figure triangle = new TriangleColor(3, 4, 5, color);
Console.WriteLine($"Площадь треугольника: {triangle.Area2}");
triangle.Print();