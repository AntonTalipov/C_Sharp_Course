/* Напишите программу, которая принимает на
вход пятизначное число и проверяет, является ли оно
палиндромом.
14212 -> нет
23432 -> да
12821 -> да */
Console.WriteLine("type a number (5 digits) which is palindrom");
int num = int.Parse(Console.ReadLine());
if (num>9999 && num<100000)
{
   if ((num/1000)/10 == num%10 && (num/1000)%10 == (num%100)/10)
   {
    Console.WriteLine("yes");
   }
   else
   {
    Console.WriteLine("no");
   }
}
else
{
    Console.WriteLine("This number isn`t consist of 5 digits"); 
}
/* int g= (num/1000)/10;// 1th
int l= (num/1000)%10;// 2th
int n= (num%100)/10;// 4th
int m= num%10;// 5th
Console.WriteLine(l); */
