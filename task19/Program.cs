/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет,
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
Console.Clear();

Console.WriteLine("Введите пятизначное число ");
int number = int.Parse(Console.ReadLine()!);
int number1=(number/10000)%10;
int number2= (number/1000)%10;
int number3=(number%100)/10;
int number4=number%10;
if (number1==number4&&number2==number3)
{
    Console.WriteLine($"Число {number} является палиндромом");
}
else
{
   Console.WriteLine($"Число {number} не является палиндромом"); 
}
