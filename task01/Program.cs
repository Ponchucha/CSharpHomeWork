﻿Console.WriteLine ("Введите первое число");
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