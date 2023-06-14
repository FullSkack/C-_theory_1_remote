// Задаем массив
int[] arr = {1,5,4,3,2,6,7,1,1};

void PrintArr(int[] array)
// Метод вывода массива на экран
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

void OrderArr(int[] array)
// Метод упорядочивания массива
{
    for (int i = 0; i < array.Length-1; i++)
    // Цикл перебора элемента
    {
        int min = i; // маркер минимального элемента

        for (int j = i+1; j < array.Length; j++)
        // Цикл сравнивающий текущий элемент с min и записывающий переменную min
        {
            if(array[j] < array[min])
            {
                min = j;
            }
        }
        
        // Механизм перемещения местами двух элементов
        int temp = array[i];
        array[i] = array[min];
        array[min] = temp;
    }
}

PrintArr(arr);
OrderArr(arr);

PrintArr(arr);


