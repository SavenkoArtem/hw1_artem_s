// See https://aka.ms/new-console-template for more information
int[] num = new int[3];

Console.WriteLine("Введите первое число");
num[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
num[1] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
num[2] = Convert.ToInt32(Console.ReadLine());

int max = num[0];

for (int i = 1; i < num.Length; i++)
{
    if (max < num[i])
    {
        max = num[i];
    }
}

Console.WriteLine("Max = {0:D}", max);
