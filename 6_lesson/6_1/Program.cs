/* Напишите программу, которая принимает на вход три
числа и проверяет, может ли существовать треугольник с сторонами
такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника
меньше суммы двух других сторон.*/
// a<(b+c), b<(a+c), c<(a+b)
Console.WriteLine("type sides of the triangle");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
void Triangle (int a,int b,int c){
if (a<(b+c) && b<(a+c) && c<(a+b))
{
 Console.WriteLine("it can be a triangle");   
}
else
{
   Console.WriteLine("it can`t be a triangle");  
}}
Triangle(a, b, c);