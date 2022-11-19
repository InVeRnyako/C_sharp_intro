// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// Расстояние между двумя точками равно квадратному корню из суммы квадратов разностей координат по каждой оси.

Console.WriteLine("Введите координаты двух точек в 3D пространстве.");

Console.WriteLine("Координаты первой точки:");
double x1 = UserCoord("x1: ");
double y1 = UserCoord("y1: ");
double z1 = UserCoord("z1: ");

Console.WriteLine("Координаты второй точки:");
double x2 = UserCoord("x2: ");
double y2 = UserCoord("y2: ");
double z2 = UserCoord("z2: ");

Console.WriteLine($"A ({x1}, {y1}, {z1}); B ({x2}, {y2}, {z2}), -> {CountLength3d(x1,x2,y1,y2,z1,z2)}");

static double UserCoord (string message)
{
    Console.Write(message);
    try
    {
        return double.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return 0;
    }
}

static double CountLength3d(double pX1,double pX2,double pY1,double pY2,double pZ1,double pZ2)
{
    return Math.Round(Math.Sqrt(Math.Pow(pX1-pX2,2) + Math.Pow(pY1-pY2,2) + Math.Pow(pZ1-pZ2,2)), 2);
}