// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N. Выполнить с помощью рекурсии.

// N = 5 -> "1, 2, 3, 3, 4"
// N = 8 -> "1, 2, 3, 4, 5, 6, 7, 8"




// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

void NaturGenRec(int m,int n)
{  
    Console.Write(m + " ");
    if (m == n)
    {
    }
    else
    {
        LineGenRec(m+1,n);
    }
}
int m = 1;
int n = ReadData("Введите число N: ");
NaturGenRec(m,n);