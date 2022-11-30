/* Напишите программу, которая
принимает на вход координаты двух точек и
находит расстояние между ними в 2D
пространстве.
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21 */

// l=sq((x2-x1)2+(y2-y1)2)
Console.WriteLine("type coordinates point A (Xa,Ya) and B(Xb,Yb)");
Console.WriteLine("type Xa");
int xa = int.Parse(Console.ReadLine());
Console.WriteLine("type Ya");
int ya = int.Parse(Console.ReadLine());
Console.WriteLine("type Xb");
int xb = int.Parse(Console.ReadLine());
Console.WriteLine("type Yb");
int yb = int.Parse(Console.ReadLine());
double Distance(int xa, int ya, int xb, int yb)
{
    double result;
    result= Math.Sqrt((Math.Pow((xb-xa), 2))+(Math.Pow((yb-ya), 2)));
    return result;
}
/*double d = Math.Sqrt((Math.Pow((xb-xa), 2))+(Math.Pow((yb-ya), 2)));
Console.WriteLine(d);*/
Console.WriteLine($"distance is {Distance(xa, ya, xb, yb)}");