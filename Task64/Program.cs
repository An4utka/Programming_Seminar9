// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

Console.Write("Enter N:");
int n=int.Parse(Console.ReadLine());
Console.WriteLine(PrintNumbers(n));
string PrintNumbers(int num)
{
if (num==1) return "1";
return (num+" "+PrintNumbers(num-1));
}
