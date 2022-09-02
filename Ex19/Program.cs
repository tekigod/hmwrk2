// Напишите программу, которая 
// 1. принимает на вход пятизначное число и 
// 2. проверяет, является ли оно палиндромом.
// Например:
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();

void checkNum (string number)
{
    if (number[0] == number[4] || number[1] == number[3]) Console.WriteLine("Введенное число является палиндромом");
    else Console.WriteLine("Введенное число - не палиндром");
}
if (number.Length == 5) checkNum(number);
else Console.Write ("Используйте только пятизначные числа!");