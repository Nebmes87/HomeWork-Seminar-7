// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

void GenerateArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintArray (int[,] array)
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
void ArithmeticMean(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        double arithmeticMean = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arithmeticMean += array[j, i];
        }
        Console.WriteLine($"Cреднее арифметическое столбца № {i+1} = {arithmeticMean/array.GetLength(1):F2}");
    }
}

int rows = 4, columns = 4;
int[,] array = new int[rows, columns];
GenerateArray (array);
PrintArray(array);
ArithmeticMean(array);