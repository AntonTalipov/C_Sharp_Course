/*Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10*/

/*Console.WriteLine("type a number");
int num = int.Parse(Console.ReadLine());
string Generation(int num)
{
string sum ="";
while (num >= 1)
{
  
  if (num % 2 > 0)
  {
    sum = "1" + sum;
    num = num / 2; 
  } 
  else
  {
    sum = "0" + sum;
    num = (num / 2) - (num % 2);
  }
}
return sum;
}
Console.WriteLine($"your number {num} in BIN system is {Generation(num)}");*/
string Bin(int n)
	{
	    string result = "";
	
	    while (n > 0)
	    {
	        result = n % 2 + result;
	        n /= 2;
	    }
	    return result;
	}
	
	Console.WriteLine(Bin(int.Parse(Console.ReadLine())));
