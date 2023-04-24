using System;
// Задача 7 HARD по желанию - идет за 2 необязательных Напишите программу, которая принимает 
// на вход целое число любой разрядности и на выходе показывает вторую цифру слева этого числа или говорит,
// что такой цифры нет. Через строку решать нельзя.
Console.WriteLine("Enter a number");
int num = Convert.ToInt32(Console.ReadLine());

int i = 0;
int count = num;

while (count != 0)
{
    i++;
    count = count / 10;
}

if (i < 2)
{
    Console.WriteLine("Нет такого числа");
}
else if (i == 2)
{
    num = num % 10;
    Console.WriteLine(num);
}
else
{    
    num = num / Convert.ToInt32(Math.Pow(10, (i-2)));
    num = num % 10;
    Console.WriteLine(num);
}
