// ---------------------------------------------------------------------
// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
// ---------------------------------------------------------------------

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int SumMNRec(int m, int n)
{
    int res = 0;
    if (m >= n)
    {

    }
    else
    {
        res = res + m + LineGenRec(m + 1, n);
    }
    return res;
}
int m = ReadData("Введите число M: ");
int n = ReadData("Введите число N: ");
Console.WriteLine("Сумма чисел в промежутке M до N равна = " + SumMNRec(m, n)+"!");