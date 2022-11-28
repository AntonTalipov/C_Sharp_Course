/* Напишите программу, которая будет принимать на
вход два числа и выводить, является ли второе число
кратным первому. Если число 2 не кратно числу 1, то
программа выводит остаток от деления.
● 34, 5 -> не кратно, остаток 4
● 16, 4 -> кратно */

string Func(int n1, int n2)
{
    if (n1 % n2 ==0)
    {
        return "кратное";
    }
    else
    {
        return $"не кратное, остаток {n1 % n2}";
    }
}
Console.WriteLine("type first number");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("type second number");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine(Func(num1, num2)); 

/* void Func(int n1, int n2)
{
    if (n1 % n2 ==0)
    {
        Console.WriteLine("кратное");
    }
    else
    {
        Console.WriteLine($"не кратное, остаток {n1 % n2}");
    }
}
Console.WriteLine("type first number");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("type second number");
int num2 = int.Parse(Console.ReadLine());
Func(num1, num2); */