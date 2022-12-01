/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine ("Введите число");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);


if (number == 1)
    Console.WriteLine ("impossible");

else
{
    if (number > 1)
    {
        for (int even = 2; even <= number; Console.Write ($"{even}, "), even = even+2);    
    }
    else
        for (int even = 0; even >= number; Console.Write ($"{even}, "), even = even-2);
}