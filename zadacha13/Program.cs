// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число: ");
string num = Console.ReadLine();

int number = int.Parse (num); // если необходимо закрыть программу при вводе значения отличного от числа.

if (num.Length > 2)
{
  Console.WriteLine($"Третья цифра числа {num} - это {num[2]}.");
}
else {
  Console.WriteLine("Третьей цифры нет");
}



