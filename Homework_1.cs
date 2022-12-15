/*Задача 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, 
а какое меньшее
Console.WriteLine("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine()!);
if(numberA > numberB)
{
    Console.Write($"Максимальное число равно {numberA}");
}
else
{
    Console.Write($"Максимальное число равно {numberB}");
}*/

/*Задача 2. Напишите программу, которая принимает на вход три числа 
и выдаёт максимальное из этих чисел
Console.WriteLine("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число: ");
int numberC = int.Parse(Console.ReadLine()!);
int max = numberA;
if(numberA > numberB)
{
max = numberA;
}
else
{
max = numberB;
}
if(max < numberC)
{
max = numberC;
}
Console.WriteLine($"Максимальным из трех введенных чисел является {max}");*/

/*Задача 3. Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
if(number%2 == 0)
{Console.WriteLine("Четное число");}
else
{Console.WriteLine("Нечетное число");}*/

//Задача 4. Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
int N1 = 1;
while(N1 <= N)
{if(N1%2 == 0)
    {Console.Write($"{N1} ");
    N1++;}
 else
    {N1++;}
}
