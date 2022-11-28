/*Напишите программу, которая выводит случайное
трехзначное число и на выходе показывает
последнюю цифру этого числа.
● 456 -> 6
● 782 -> 2
● 918 -> 8 */
int MaxNumber(int num)
{
 Console.WriteLine(num); 
 return num % 10;
}
Console.WriteLine(MaxNumber(new Random().Next(100, 1000)));