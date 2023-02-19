// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1000 && number > 99)
{
    int ThreeDigit = number % 10;
    Console.WriteLine($"Третья цифра: {ThreeDigit}");
}
else if (number == 1000 || number > 1000)
{
    Console.Write("Некорректный ввод чисел.");
}
else if (number < 100)
{
    Console.Write("Третьей цифры нет.");
}