// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 -> 1, 8, 27, 64, 125
Console.Write("Введите число N: ");
int N = userInputInt();

string result = "1";
int i = 2;
int d = 1; // direction
if (N < 0) 
{   
    d = -1;
    result = "1, 0, -1";
}
else if (N == 0) result = "1, 0";

while (i <= N * d)
{
    result = $"{result}, {Math.Pow(i * d,3)}";
    i++;
}

Console.Write($"{N} -> {result}");

static int userInputInt()
{
    try
    {
        return int.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return 0;
    }
}