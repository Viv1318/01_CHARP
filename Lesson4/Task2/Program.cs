// задать двумерный массив, четные числа назвать "интересные"
int[,] CreateMatrix (int rowCount, int columsCount)
{
    int[,] matrix = new int [rowCount, columsCount];
    Random random = new Random();//ресурсремкие операции лучше выносить за пределы цикла
    for (int i = 0; i < matrix.GetLength(0); i++) // (0) запрашивает кол -во строк
    {
        for (int j = 0; j < matrix.GetLength(1); j++)// (1) запрос колв-ва столбцов
        {
            matrix[i,j] = random.Next(1, 1000);
        }
    }
    return matrix;
}
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

int[,] matrix = CreateMatrix(3, 4);
ShowMatrix(matrix);

foreach (int e in matrix)
{
   if (IsInteresting(e) == true)
   {
        Console.WriteLine(e);
   }
}

bool IsInteresting(int value)
{
   int sumOfDigits = GetSumOfDigits(value);
   if(sumOfDigits % 2 == 0)
   {
    return true;
   }
    return false;
}

int GetSumOfDigits (int value)
{
    int sum = 0;
    while(value > 0)
    {
        sum = sum + value % 10;
        value = value / 10;
    }
    return sum;
}