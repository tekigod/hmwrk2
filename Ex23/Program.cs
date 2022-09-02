// Напишите программу, которая 
// 1. принимает на вход число (N) и 
// 2. выдаёт таблицу кубов чисел от 1 до N.
// Например: 
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
          Console.WriteLine ($"{i}\t{i*i*i}");

        Console.ReadLine();
    }
}