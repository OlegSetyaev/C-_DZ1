// Программа которая выдаёт максимальное из 3х чисел
Console.WriteLine("Введите первое число");
int firstNumber = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondNumber = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите третье число");
int thirdNumber = Convert.ToInt32 (Console.ReadLine());
int max = (firstNumber);
if (max < secondNumber)
    max = secondNumber;
if (max < thirdNumber)
    max = thirdNumber;
Console.WriteLine(max);
