﻿// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника 
// меньше суммы двух других сторон.


Console.Clear();
Console.WriteLine("введите 1-е число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите 2-е число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите 3-е число: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a < b + c && b < a + c && c < a + b)
    Console.WriteLine("можно построить треугольник");
else Console.WriteLine("нельзя построить треугольник");

