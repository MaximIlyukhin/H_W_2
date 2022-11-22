//Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

using static System.Console;
Clear();

//Write("Enter N = ");
//string N = Console.ReadLine();
//if((int) N/100!=0)
//    Write(N[2]);
//else
//    Write("третьей цифры нет");

Write("Enter N = ");
int N = int.Parse(Console.ReadLine());
if(N/100!=0){
    string str = N.ToString();
    Write(str[2]);}
else{
    Write("третьей цифры нет");}


    


    