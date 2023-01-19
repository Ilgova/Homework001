Console.WriteLine("Проверка на чётность");
Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = 2;

if ((number1 % number2) == 0)
{
Console.WriteLine($"{number1} - ДА ");
}
else 
{
   Console.WriteLine($"{number1} - НЕТ "); 
}