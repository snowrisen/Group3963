// Задача 2: Напишите программу,
// которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.

int numA = Convert.ToInt32(Console.ReadLine("Введите первое число: "));
int numB = Convert.ToInt32(Console.ReadLine("Введите второе число: "));
if ( numA > numB ) 
{
     Console.WriteLine("Первое число больше второго");

else 
Console.WriteLine("Второе число больше первого");
  
 }
