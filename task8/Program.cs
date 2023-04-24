// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Enter a number");
int num = Convert.ToInt32(Console.ReadLine());

int i = 0;

while (i < Math.Abs(num))
{
    i++;
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}
