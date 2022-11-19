// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 -> 1, 8, 27, 64, 125
Console.Write("Введите число N: ");
int N = userInputInt();

Console.Write($"{N} -> {LinePowsFromOneToNResultString(N, 3)}");

static string LinePowsFromOneToNResultString(int tempN, int power)
{
    string lpResult = "1";
    int i = 2;
    int d = 1; // direction
    if (tempN < 0) 
    {   
        d = -1;
        lpResult = "1, 0, -1";
    }
    else if (tempN == 0) lpResult = "1, 0";

    while (i <= tempN * d)
    {
        lpResult = $"{lpResult}, {Math.Pow(i * d,power)}";
        i++;
    }
    return lpResult;
}

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