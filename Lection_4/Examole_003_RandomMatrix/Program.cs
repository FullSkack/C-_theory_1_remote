// Метод Перебирающий элементы массива и выводящий на экран
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    }
}

// Метод наполняющий массив случайными элементами
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    // Вложенный цикл, перебора строк - i, столбцов - j
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        // заполняем i-й и j-й элементы массива случайными числами ОТ 1 ДО 10
        {
            matr[i,j] = new Random().Next(1,10);
        }
    }
}

int[,] matrix = new int[3, 4]; // задаем размерность массива
PrintArray(matrix);

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
