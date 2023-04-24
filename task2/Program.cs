// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("Max a: {0:D}", a);
}
else if (a == b)
{
    Console.WriteLine("Числа равны");
}
else
{
    Console.WriteLine("Max b: {0:D}", b);
}

