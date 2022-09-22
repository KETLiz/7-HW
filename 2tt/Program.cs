// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] FillMatrix()
{
    int[,] matr = new int[5, 5];
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rnd.Next(1, 100);
        }
    }
    return matr;
}


void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j < matr.GetLength(1)- 1) Console.Write($"{matr[i, j], 3}, ");
            else Console.WriteLine($"{matr[i, j], 3}");
        }
    }
}
int[,] matrix = FillMatrix();
PrintMatrix(matrix);

Console.Write("Введите индекс строки: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите индекс столбца: ");
int column = Convert.ToInt32(Console.ReadLine());

string Search(int[,] matr)
{
    if (row > matr.GetLength(0) && column > matr.GetLength(1)) return "Такого элемента нет";
    else return $"Значение элемента, находящегося на {row} строке, {column} столбца = {matr[row-1, column-1]}";
}
string result = Search(matrix);
Console.WriteLine(result);