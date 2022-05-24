//Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее 
//арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] NewMatrix(int a, int b)
{
    int[,] martix = new int[a, b];
    for (int i = 0; i < martix.GetLength(0); i++)
    {
         for (int j = 0; j < martix.GetLength(1); j++)
        {
            martix[i, j] = new Random().Next(0, 10);
            Console.Write(martix[i, j] + " ");
        }
        Console.WriteLine();
        }
    Console.WriteLine();
    return martix;
}
void Average(int[,] array)
{
    double[] summ = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
         for (int j = 0; j < array.GetLength(1); j++)
        {
            summ[j] = summ[j] + array[i,j];
        }
    }
    Console.Write("Среднее арифметическое элементов в каждом столбце: ");
    for (int i = 0; i < summ.Length; i++)
    {
        Console.Write((Math.Round((summ[i]/array.GetLength(0)), 1)) + " "); 
        }
    }
    int rows = new Random().Next(2, 10);
    int columns = new Random().Next(2, 10);
    Console.WriteLine("Массив:");
    Average(NewMatrix(rows, columns));
        