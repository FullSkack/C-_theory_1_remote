﻿// Вложенный цикл, генерация таблицы умножения
for (int i = 2; i <= 10; i++) // первый цикл набирает числа для таблицы
{
    for (int j = 2; j <= 10; j++) // второй производит перемножение на нужные цифры
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    System.Console.WriteLine(); // команда отступа строки в конце второкго цикла
}
