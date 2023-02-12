// Задача 0
// Напишите программу, которая на вход принимает число и
// выдаёт его квадрат (число умноженое на само себя)

//Считываем данные с консоли
Console.WriteLine("Введите число: ");

string? inputNum = Console.ReadLine();

// Проверяем, чтобы данные были не пустыми

if(inputNum != null)
{
    // Парсим введённое число
  int number = int.Parse(inputNum);

// Находим квадрат числа
  int outNum = number*number;

// вводим данные в консоль
  Console.WriteLine("Квадрат числа: "+outNum);

  Console.WriteLine(Math.Pow(int.Parse(inputNum),2));


}
