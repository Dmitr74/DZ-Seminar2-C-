// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Введите день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 6)
{
    Console.Write("Выходной, (Да)");
}
else if (day == 7)
{
    Console.Write("Выходной, (Да)");
}
else if (day > 7)
{
    Console.Write("Некорректный ввод");
}
else
{
    Console.Write("Рабочий день, (Нет)");
}