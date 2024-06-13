//  Создать двумернай маасив 3 на 5
// вывести его на икран
int[,] CreateMatrix (int rowCount, int columsCount)
{
    int[,] matrix = new int [rowCount, columsCount];
    Random random = new Random();//ресурсремкие операции лучше выносить за пределы цикла
    for (int i = 0; i < matrix.GetLength(0); i++) // (0) запрашивает кол -во строк
    {
        for (int j = 0; j < matrix.GetLength(1); j++)// (1) запрос колв-ва столбцов
        {
            matrix[i,j] = random.Next(1, 11);
        }
    }
    return matrix;
}
// вывод созданного массива
void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");// интерполяция сторк (вывод элементов массива)
        }
        System.Console.WriteLine();
    }
}

int[,] matrix = CreateMatrix(4, 5);
ShowMatrix(matrix);