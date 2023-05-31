// Использование массива на примере нахождения масимума.
int Max(int arg1, int arg2, int arg3) // объявление функции
{
    // Тело функции
    int result = arg1; 
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result; // Вывод результата вычислений
}

int [] array = {11,21,31,481,15,61,17,18,19}; // запись массива значений

int max = Max( // применение функции к соотвтесвующему элементу массива.
Max(array[0], array[1], array[4]),
Max(array[3], array[4], array[5]),
Max(array[6], array[7], array[8])); 

Console.WriteLine(max);