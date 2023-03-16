// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1



// int number = ReadInt("Введите трехзначное число: ");
// int size = number.ToString().Length;

// if (size < 3 || size > 3)
// {
//     Console.WriteLine("Вы ввели не трехзначное число");
// }
// else
// {
//     Console.WriteLine(InCenter(number));
// }


// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int InCenter(int a)
// {
    
//     int result = ((a / 10) % 10);
//     return result;
// }

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6



// Console.Write("Введи число: ");
// int Number = Convert.ToInt32(Console.ReadLine());
// string NumberText = Convert.ToString(Number);
// if (NumberText.Length > 2)
// {
//   Console.WriteLine($"Третья цифра: {NumberText[2]}");
// }
// else 
// {
//   Console.WriteLine("Третьей цифры нет!");
// }

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek(int dayNumber)
{
  if (dayNumber == 6 || dayNumber == 7)
  {
    Console.WriteLine("Этот день ВЫХОДНОЙ!");
  }
  else if (dayNumber < 1 || dayNumber > 7)
  {
    Console.WriteLine("Введите правильную цифру!");
  }
  else Console.WriteLine("Этот день РАБОЧИЙ!");
}

CheckingTheDayOfTheWeek(dayNumber);