// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введи цифру, обозначающую день недели: ");
string num = Console.ReadLine();
int dayNum = int.Parse(num);

if (dayNum == 1)
{
    Console.WriteLine("Понедельник - день тяжелый! И это не выходной.");
}
else if (dayNum == 2)
{
    Console.WriteLine("Вторник - этот будний день... Крепись!");
}
else if (dayNum == 3)
{
    Console.WriteLine("Среда - этот будний день... Но, как говорится: среда - это маленькая пятница!");
}
else if (dayNum == 4)
{
    Console.WriteLine("Четверг этот будний день... Не время расслабляться!");
}
else if (dayNum == 5)
{
    Console.WriteLine("Пятница - этот будний день... Крепись! Выходные не за горами!");
}
else if (dayNum == 6)
{
    Console.WriteLine("Суббота - это выходной день! Можно погулять с друзьями.");
}
else if (dayNum == 7)
{
    Console.WriteLine("Воскресенье - это выходной день! Завтра на работу, ложись пораньше.");
}
else
    Console.WriteLine("В неделе 7 дней ;)");