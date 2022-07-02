// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int Prompt(string message)
{
  System.Console.Write(message);
  return Convert.ToInt32(Console.ReadLine());
}
int[,] GenerateArray (int row, int column)
{
    int[,] array = new int[row,column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
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
string FindElement(int[,] array, int rowPos, int columnPos)
{
    string result = String.Empty;
    if(rowPos > array.GetLength(0) || columnPos > array.GetLength(1) || rowPos <= 0 || columnPos <= 0)
      result = $"Введенной позиции не существует";
    else   
      result = $"На введенной позиции находится элемент: {array[rowPos-1, columnPos-1]}";
    return result;
}

int rowPos = Prompt("Введите номер строки: ");
int columnPos = Prompt("Введите номер столбца: ");
int row = 6, column = 6;
int[,] array = GenerateArray (row, column);
PrintArray(array);
string result = FindElement(array,rowPos,columnPos);
System.Console.WriteLine(result);