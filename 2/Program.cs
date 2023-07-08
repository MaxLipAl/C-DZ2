//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine ());
int number1 = number;

if (number / 100 < 1)
{
    Console.WriteLine($"{number} -> третьей цифры нет");
}
else 
{
    if (number / 100 < 10)
    {
        Console.WriteLine($"{number} -> {number % 10}");
    }
else
{
    while (number / 100 > 10)
    {
        number = number / 10;
    }
    Console.WriteLine($"{number1} -> {number % 10}");
}
}