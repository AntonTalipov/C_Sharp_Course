/* Напишите программу, которая выводит случайное
трёхзначное число и удаляет вторую цифру этого числа.
645 -> 65
782 -> 72
918 -> 98 */

string DeleteMedium(int num)
{
    return num.ToString().Remove(1, 1);
}

int num1=new Random().Next(100, 1000);
Console.WriteLine(num1);
Console.WriteLine(DeleteMedium(num1));