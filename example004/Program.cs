Console.WriteLine("Введите 3 числа, найдем максимальное из этих чисел");
Console.WriteLine("Введите 1 число");
int number1 = Convert.ToInt32(Console.ReadLine() );
Console.WriteLine("Введите 2 число");
int number2 = Convert.ToInt32(Console.ReadLine() );
Console.WriteLine("Введите 3 число");
int number3 = Convert.ToInt32(Console.ReadLine() );

int max = number1;
if (max < number2)
{
    max = number2;
}
if (max < number3)
{
    max = number3;
}
Console.WriteLine($"Максимальное число из чисел {number1}, {number2}, {number3} равно {max}");
