/* Напишите программу, которая
принимает на вход число N и выдаёт
произведение чисел от 1 до N.
4 -> 24
5 -> 120 */
Console.WriteLine("type a number");
int number =int.Parse(Console.ReadLine());
int Fractal(int num)
{
    int sum = 1;
    for (int i = 1; i <=num; i++)
    {
    sum = sum*i ; 
    }
    return sum;
}
Console.WriteLine(Fractal(number));