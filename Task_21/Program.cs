/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.*/

int xA = Coordinate("x", "A");
int yA = Coordinate("y", "A");
int zA = Coordinate("z", "A");
int xB = Coordinate("x", "B");
int yB = Coordinate("y", "B");
int zB = Coordinate("z", "B");
int Coordinate(string coor, string point)
{
    Console.Write($"Введите координату {coor} точки {point} ");
    return Convert.ToInt16(Console.ReadLine());
}
double Decision(double xA, double xB, double yA, double yB, double zA, double zB)
{
  return Math.Sqrt(Math.Pow((xB-xA), 2) + Math.Pow((yB-yA), 2) + Math.Pow((zB-zA), 2));
}
double length = Decision(xA, xB, yA, yB, zA, zB);
Console.WriteLine($"Длина отрезка  {length}");