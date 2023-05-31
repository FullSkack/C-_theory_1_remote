// See https://aka.ms/new-console-template for more information
int[] array = {1,12,31,4,15,16,17,18}; // задаём массив

int n = array.Length; // узнаем длинну массива
int find = 8; // задаем значение переменной для сравнения
int index = 0; // задаем переменную счетчик
while (index < n) // цикл для перебора всех элементов и нахождения нужного индекса
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }

    index ++;
}