/* Напишите программу, которая принимает на вход
число и проверяет, кратно ли оно одновременно
7 и 23.
● 14 -> нет
● 46 -> нет
● 161 -> да */

string Div(int num)
{
if (num % 7 == 0 && num % 5 == 0)
{
    return "Yes";
}
else
{
    return "No";
}
}
Console.WriteLine("type a number");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine(Div(num1));