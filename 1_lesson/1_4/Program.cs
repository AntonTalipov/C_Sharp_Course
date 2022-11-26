// Напишите программу вычисления
// модуля числа.
// 6 -> 6
// -82 -> 82

Console.WriteLine("Write a number:");
var s = Console.ReadLine();
int n = s == null ? 0 : int.Parse(s);
Console.WriteLine($"{Math.Abs(n)}");
