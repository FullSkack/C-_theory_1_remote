// See https://aka.ms/new-console-template for more information
int[] array = new int[10]; // задаем колличесвто эллементов массива

void FillArray(int[] collection) // Объявляем метод и переменные для работы
{
    int length = collection.Length;
    int index = 0;

    while (index < length) // цикл перебора и присвоения случайного значения элементу
    {
        collection[index] = new Random().Next(1, 10);
        index ++;
    }
}

void PrintArray(int[] massiv) // Объявляем метод и переменные для работы
{
    int count = massiv.Length;
    int position = 0;

    while (position < count) // цикл перебора и вывода в консоль соответсвующего элемента
    {
        Console.Write(massiv[position]);
        position ++;
    }
}

FillArray(array);
PrintArray(array);
