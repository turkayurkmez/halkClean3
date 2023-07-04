// See https://aka.ms/new-console-template for more information
using LiskovSubstution;

Console.WriteLine("Hello, World!");
//Square square = new Square() { Width = 5 };
//Console.WriteLine(square.GetArea());

//Rectangle rectangle = new Rectangle { Width = 20, Height = 9 };
//Console.WriteLine(rectangle.GetArea());

var rect = GeometryFactory.GetRectangle(10, 3);
//rect.Width = 5;
//rect.Height = 9;

Console.WriteLine(rect.GetArea());