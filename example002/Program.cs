Console.WriteLine("Введите 2 числа, проверим какое число большее, а какое меньшее");
Console.WriteLine("Введите 1 число");
int number1 = Convert.ToInt32(Console.ReadLine() );
Console.WriteLine("Введите 2 число");
int number2 = Convert.ToInt32(Console.ReadLine() );

if (number1 < number2)
{
Console.WriteLine($"Число {number1} меньше числа {number2}");
}
else 
{
Console.WriteLine($"Число {number1} больше числа {number2}");    
}