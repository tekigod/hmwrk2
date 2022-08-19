// Напишите программу, которая 
// 1. принимает на вход число (N) и 
// 2. выдаёт таблицу кубов чисел от 1 до N.
// Например: 
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int cell = Convert.ToInt32(Console.ReadLine());

void Cube(int[] cell){
  int counter = 0;
  int length = cell.Length;
  while (counter <  length){
    cell[counter] = Convert.ToInt32(Math.Pow(counter, 3));
    counter++;
  }
}

void PrintArry(int[] CL222){
  int count = CL222.Length;
  int index = 0;
  while(index < count){
    Console.Write(CL222[index]+ " ");
    index++;
  }
} 

int[] arry = new int[cell+1];
Cube(arry);
PrintArry(arry);