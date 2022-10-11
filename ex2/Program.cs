Console.WriteLine ("Введите число a: ");
int a = int.Parse (Console.ReadLine ());

Console.WriteLine ("Введите число b: ");
int b = int.Parse (Console.ReadLine ());

if (a == b * b)
{
    Console.WriteLine ("Число а является квадратом числа b");
}

else if (b == a * a)
{
    Console.WriteLine ("Число b является квадратом числа a");
}

else
{
    Console.WriteLine ("Одно число не является квадратом другого");
}