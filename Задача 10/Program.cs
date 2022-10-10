// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n<100) 
Console.WriteLine("Введите коректное значения");
else {
while(n > 100)
n = n / 10;
Console.WriteLine(n % 10);
}