//Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

void NewArray(int m, int n)
{
    double[,] array = new double[m, n];
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            array[a, b] = Math.Round((new Random().NextDouble()-0.5) * 100, 1); // округление до 1 знака после запятой
            Console.Write(array[a, b] + " ");
        }
        Console.WriteLine();
    }

}
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
NewArray(rows, columns);