Console.WriteLine("Все чётные числа от 1 до N");
Console.Write("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
int i = 2;
Console.WriteLine($"Все чётные числа от 1 до {N}");
if (N > 1)
{
    while (i <= N)
    {
    Console.Write(i + " ");
    i = i + 2;
    }
}
