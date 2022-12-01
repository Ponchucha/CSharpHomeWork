/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
Console.WriteLine ("Введите первое число");
string numberOneStr = Console.ReadLine();
int numberOne = Convert.ToInt32(numberOneStr);

Console.WriteLine ("Введите первое число");
string numberTwoStr = Console.ReadLine();
int numberTwo= Convert.ToInt32(numberTwoStr);

if (numberOne>numberTwo)
{
    Console.WriteLine ($"{numberOne} is larger");
}
else
    if (numberOne<numberTwo)
    {
        Console.WriteLine ($"{numberTwo} is larger");
    
    }
    else Console.WriteLine ("nubers are equal");