string[,] table = new string[2,5]; // числа в [] - размерность массива

// String.Empty
// table [0,0] table [0,1] table [0,2] table [0,3] table [0,4]
// table [1,0] table [1,1] table [1,2] table [1,3] table [1,4]

table[1, 2] = "слово";

for (int rows = 0; rows < 2; rows++)
// вложенный цикл перебирающий сначала строки, потом столбцы и выводящий в терем
{
    for (int columns = 0; columns < 5; columns++)
    {
        // обращаемся к массиву через индексы
        Console.WriteLine($"-{table[rows, columns]}");  
        // добавили "-" для наглядности, как выводяться вызываемые элементы
    }
}



