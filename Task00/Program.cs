﻿// Напишите программу, которая на вход 
// принимает число и выдаёт его квадрат (число 
// умноженное на само себя).
// Например:
// 4 -> 16 
// -3 -> 9
// -7 -> 49

Console.WriteLine("Hello, enter your namber.");
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;
Console.Write("Square="+square);

