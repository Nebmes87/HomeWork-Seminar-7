// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
void GenerateArray (double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100)/10.0;
        }
    }
}
void PrintArray (double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "  ");
        }
        System.Console.WriteLine();
    }
}

int rows = Prompt("Введите m: ");
int columns = Prompt("Введите n: ");
double[,] Array = new double[rows, columns];
GenerateArray(Array);
PrintArray(Array);

// или

void CreateArrayDouble(double[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().NextDouble() * 20 - 10;
    }
  }
}

void WriteArray (double[,] array){
for (int i = 0; i < array.GetLength(0); i++)
  {
      for (int j = 0; j < array.GetLength(1); j++)
      {
        double alignNumber = Math.Round(array[i, j], 1);
        Console.Write(alignNumber + "  ");
      }
      Console.WriteLine();
  }
}

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m, n];

CreateArrayDouble(array);
WriteArray(array);
