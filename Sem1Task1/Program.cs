// Задача №1 Напишите программу, которая на вход 
// принимает два числа и проверяет, 
// является ли первое число квадратом второго.

// //ввод числа №1
// Console.Write("Введите число №1: ");
// string numLine1 = Console.ReadLine();
// //ввод числа №2
//  string numLine2 = Console.ReadLine();

//  if(numLine1!=null && numLine2!=null)
// {
// //Convert to int
//  int num1 = int.Parse(numLine1);
//  int num2 = int.Parse(numLine2); 
//  if(num2*num2 == num1) 
//             //  {       
//  Console.WriteLine("Да, является!");

//     }   
//     else   
//  {       
//  Console.WriteLine("Нет, не является!");   
//   }


        
            int smallNumber, bigNumber, countOfEven, countOfOdd, sumOfEven, sumOfOdd;
            countOfEven = 0;
            countOfOdd = 0;
            sumOfEven = 0;
            sumOfOdd = 0;
            Console.WriteLine("Введите меньшее число");
            smallNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите большее число");
            bigNumber = int.Parse(Console.ReadLine());

            while (bigNumber != smallNumber + 1)
            {
                bigNumber--;
                if (bigNumber % 2 == 0)
                {
                    countOfEven++;
                    sumOfEven += bigNumber;
                }
                else
                {
                    countOfOdd++;
                    sumOfOdd += bigNumber;
                }
            }
            Console.WriteLine("Количество четных чисел равно:" + countOfEven);
            Console.WriteLine("Количество нечетных чисел равно:" + countOfOdd);
            Console.WriteLine("Сумма четных чисел равна:" + sumOfEven);
            Console.WriteLine("Сумма нечетных чисел равно:" + sumOfOdd);