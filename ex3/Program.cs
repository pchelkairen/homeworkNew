Console.WriteLine ("Введите четверть: ");
int a = int.Parse (Console.ReadLine ());

if (a == 1)
{
    Console.WriteLine ("Диапазон возможных координат x>0 и y>0");
}

else if (a == 2)
{
   Console.WriteLine ("Диапазон возможных координат x<0 и y>0"); 
}

else if (a == 3)
{
   Console.WriteLine ("Диапазон возможных координат x<0 и y<0"); 
}

else
{
   Console.WriteLine ("Диапазон возможных координат x>0 и y<0"); 
}