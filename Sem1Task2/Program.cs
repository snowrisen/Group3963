﻿// Задача 2: Напишите программу,
// которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());

if ( numA > numB ) 
{
     Console.WriteLine("Первое число больше второго");
}
   else 
   {
Console.WriteLine("Второе число больше первого");
   }


 
  
