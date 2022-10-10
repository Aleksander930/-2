// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
while( n < 1 || n > 7 ) 
n = Convert.ToInt32(Console.ReadLine());
if ( n > 5 )
Console.WriteLine("Выходной");
else 
Console.WriteLine("Будни");

