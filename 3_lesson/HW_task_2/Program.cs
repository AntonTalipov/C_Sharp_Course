/* Напишите программу, которая принимает на
вход координаты двух точек и находит расстояние между
ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */
Console.WriteLine("type coordinates point A (Xa,Ya,Za), B(Xb,Yb,Zb)");
Console.WriteLine("type Xa");
int xa = int.Parse(Console.ReadLine());
Console.WriteLine("type Ya");
int ya = int.Parse(Console.ReadLine());
Console.WriteLine("type Za");
int za = int.Parse(Console.ReadLine());
Console.WriteLine("type Xb");
int xb = int.Parse(Console.ReadLine());
Console.WriteLine("type Yb");
int yb = int.Parse(Console.ReadLine());
Console.WriteLine("type Zb");
int zb = int.Parse(Console.ReadLine());
double Distance(int xa, int ya, int za, int xb, int yb, int zb)
{
    double result;
    result= Math.Sqrt((Math.Pow((xb-xa), 2))+(Math.Pow((yb-ya), 2))+(Math.Pow((zb-za), 2)));
    double res = Math.Round(result);
    return res;
}
/*double d = Math.Sqrt((Math.Pow((xb-xa), 2))+(Math.Pow((yb-ya), 2)));
Console.WriteLine(d);*/
Console.WriteLine($"distance is {Distance(xa, ya, za, xb, yb, zb)}");