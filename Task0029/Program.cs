﻿// Напишите программу, которая задает массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] array = new int[8] {1, 2, 5, 7, 19, 6, 1, 33};
foreach (int element in array)
{
    Console.Write(element + " ");
}



