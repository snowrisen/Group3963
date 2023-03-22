// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Чтение данных из консоли
Console.Clear();
uint ReadData(string line)
{
    Console.Write(line);
    uint number = uint.Parse(Console.ReadLine() ?? "0");
    return number;
}

 uint FunAkkRec(uint n, uint m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return FunAkkRec(n - 1, 1);
    else
        return FunAkkRec(n - 1, FunAkkRec(n, m - 1));
}
uint n = ReadData("Введите целое неотрицательное число N: ");
uint m = ReadData("Введите целое неотрицательное число M: ");
System.Console.WriteLine("A(m,n)= "+FunAkkRec(n,m));