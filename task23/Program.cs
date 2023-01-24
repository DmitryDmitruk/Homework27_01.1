/*Задача 23
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/
Console.Clear();

Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine()!);
int count =1;
double  num = 0;
while (count<number+1)
{
     num=Math.Pow(count,2)*count;
    Console.Write($"{num} ");
    count++;
}    
 