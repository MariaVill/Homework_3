// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число от 1:");
int N = Convert.ToInt32(Console.ReadLine());
while (N < 1)
{
    Console.WriteLine("Неверно.Введите число от 1:");
    N = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("");
Console.WriteLine($"Молодец! Таблица кубов от 1 до {N},будет следующей");
int i = 1, result = 0;
while (i <= N)
{
    result = i * i * i;
    Console.WriteLine(result);
    i++;
}
