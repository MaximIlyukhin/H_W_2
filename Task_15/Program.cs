// Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
 

using static System.Console;
Clear();

Write("Enter n = ");
int n = int.Parse(ReadLine());
if(n<8 && n>5)
    Write("Yes");
else
    Write("No");