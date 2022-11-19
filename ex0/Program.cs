// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
int userFDnum = userInputInt();

if (userFDnum >= 10000 && userFDnum < 100000)
{
    string pldrmCheck = "";
    if (palindromeNumCheck(userFDnum) == true) pldrmCheck = "да";
    else pldrmCheck = "нет";
    Console.WriteLine($"{userFDnum} -> {pldrmCheck}");
}
else Console.WriteLine("Ошибка. Введено некорректное число.");

static bool palindromeNumCheck(int palindromeNumInput)
{
    if (numLength(palindromeNumInput) == 2)
        if (digitAtPossitionNumber(palindromeNumInput, 1) ==  digitAtPossitionNumber(palindromeNumInput, 2))
            return true;
        else
            return false;
    else
    {
        int i = 1;
        while (i < numLength(palindromeNumInput) / 2)
        {
            if (digitAtPossitionNumber(palindromeNumInput, i) ==
            digitAtPossitionNumber(palindromeNumInput, numLength(palindromeNumInput) - (i - 1)) )
            {
                i++;
            }
            else 
                return false;
        }
    }
    return true;
}

static int digitAtPossitionNumber(int inputNumb, int lfNum)
{
    if (inputNumb < 0) inputNumb = inputNumb * -1;
    if (lfNum > numLength(inputNumb))
        return -1;
    else 
        return inputNumb / Convert.ToInt32(Math.Pow(10, numLength(inputNumb) - lfNum)) % 10;
}

static int numLength(int numLengthInput)
{
    int i = 0;
    do 
    {
        i++;
        numLengthInput = numLengthInput / 10;
    }
    while(numLengthInput != 0);
    
    return i;
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