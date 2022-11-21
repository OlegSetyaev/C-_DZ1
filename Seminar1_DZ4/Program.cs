// Программа которая принимает число N, а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;
for (i = 1; i <= n; i++)
    if  (i % 2 == 0) {
        Console.Write($"{i}");
       if ( i + 1 < n)
       Console.Write(",");
    }
    else if (i==n)
        Console.WriteLine();