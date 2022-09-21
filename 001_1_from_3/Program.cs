// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.

using static System.Console;
Clear();
WriteLine("Введите трехзначное число: ");
int Number = Convert.ToInt32(ReadLine()!);
int a = Number%100/10;
WriteLine($"Второй цифрой числа {Number} является {a}");
