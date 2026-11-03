Console.Write("Введите вещественное число: ");
double number = double.Parse(Console.ReadLine());

Console.WriteLine($"Округление до целого: { number:F0}");
Console.WriteLine($"До 1 знака: {number:F1}");
Console.WriteLine($"До 2 знаков: {number:F2}");
Console.WriteLine($"До 3 знаков: {number:F3}");
