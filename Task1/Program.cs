// Напишите программу, которая принимает на 
// вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
while(number < 10000 || number > 100000)
{
    Console.WriteLine("Неверно. Введите пятизначное число: ");
    number = Convert.ToInt32(Console.ReadLine());
}
int n5, n4, n3, n2, n1;
n5 = number % 10;
n4 = number / 10 % 10;
n3 = number / 100 % 10;
n2 = number / 1000 % 10;
n1 = number / 10000;

if ((n1 == n5) && (n2 == n4) && (n3 == n3))
{
    Console.WriteLine("Да, Данное число является палиндромом");
}
else
{
    Console.WriteLine("Нет, Данное число НЕ является паллиндромом");
}