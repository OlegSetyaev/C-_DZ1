// Программа которая на вход принимает целое число и выдаёт, является число чётным.
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32 (Console.ReadLine());
if ((number % 2) == 1)
    Console.WriteLine(number + "->NO");
else if ((number % 2) == 0)
    Console.WriteLine(number + "->YES");