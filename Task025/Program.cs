﻿// Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В.
// 3, 5 -> 243
// 2, 4 -> 16

int value = 2;
for (int power = 1; power <=4; power++)
Console.WriteLine($"{value}^{power} = {(long)Math.Pow(value, power)}");
