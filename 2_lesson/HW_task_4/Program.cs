/* Напишите программу, которая принимает на вход цифру,
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */
Console.WriteLine("type number from 1 to 7");
int num = int.Parse(Console.ReadLine());
if (num>=1 && num<=5)
{
    Console.WriteLine("no");
}
else if (num>=6 && num<=7)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("it isn`t day of the week");
}