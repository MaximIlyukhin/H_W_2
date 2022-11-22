//Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

using static System.Console;
Clear();

Write("Enter N = ");
int N = int.Parse(ReadLine());
WriteLine(N%100/10);