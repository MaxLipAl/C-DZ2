//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine ());
int number1 = number;

if (number >= 100 && number <=999)
{
    number = (number / 10) % 10;
    Console.WriteLine ($"{number1} -> {number}");
}
else
{
    Console.WriteLine("Надо было ввести трехзначное число.");
}



