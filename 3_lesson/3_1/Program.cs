/* Напишите программу, которая по
заданному номеру четверти, показывает диапазон
возможных координат точек в этой четверти (x и y) */
void Dip(int quat)
{
    if (quat==1)
    {
       Console.WriteLine("Diapazone is x>0 and y>0"); 
    }
    else if (quat==2)
    {
       Console.WriteLine("Diapazone is x<0 and y>0"); 
    }
    else if (quat==3)
    {
       Console.WriteLine("Diapazone is x<0 and y<0"); 
    }
    else if (quat==4)
    {
       Console.WriteLine("Diapazone is x>0 and y<0"); 
    }
}
Dip(3);