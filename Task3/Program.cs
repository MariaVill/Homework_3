// Напишите программу, которая принимает 
// на вход координаты двух точек и находит расстояние между ними в 3D пространстве
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки А x1, y1, z1 :");
double x1 = Convert.ToInt32(Console.ReadLine());
double y1 = Convert.ToInt32(Console.ReadLine());
double z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Теперь введите координаты точки В x2, y2, z2 :");
double x2 = Convert.ToInt32(Console.ReadLine());
double y2 = Convert.ToInt32(Console.ReadLine());
double z2 = Convert.ToInt32(Console.ReadLine());

double AB;
AB =Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2));
Console.WriteLine($"Расстояние между точками А({x1},{y1},{z1}) и В({x2},{y2},{z2}) равно AB = {AB}");

