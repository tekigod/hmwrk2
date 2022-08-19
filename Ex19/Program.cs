// Напишите программу, которая 
// 1. принимает на вход пятизначное число и 
// 2. проверяет, является ли оно палиндромом.
// Например:
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите число: ");
string? num1 = Console.ReadLine();

void CheckingNumber(string num1){
  if (num1[0]==num1[4] || num1[1]==num1[3]){
    Console.WriteLine($"Число: {num1} - является палиндромом.");
  }
  else Console.WriteLine($"Число: {num1} - не является палиндромом.");
}

if (num1!.Length == 5){
  CheckingNumber(num1);
}
else Console.WriteLine($"Введите пятизначное число!");