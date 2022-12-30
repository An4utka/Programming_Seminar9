// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в 
// промежутке от M до N.

Console.Clear();
Console.Write("Enter M:");
int m=int.Parse(Console.ReadLine());
Console.Write("Enter N:");
int n=int.Parse(Console.ReadLine());
Console.WriteLine(SumNumbers(m,n));
int SumNumbers(int start, int end)
{
if (start==end) return end;
int answer=start + SumNumbers(start+1,end);
return answer;
}