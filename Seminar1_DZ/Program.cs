// Программа для поиска наибольшего из двух чисел.
Console.WriteLine ("Введите первое число: ");
int FirstNumber = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите второе число: ");
int SecondNumber = Convert.ToInt32 (Console.ReadLine());
if (FirstNumber > SecondNumber)
    Console.WriteLine ("Наибольшее число "+FirstNumber);
else 
    Console.WriteLine ("Наибольшее число "+SecondNumber);
