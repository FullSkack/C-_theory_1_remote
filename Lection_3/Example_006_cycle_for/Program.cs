// Использование цикла for
string Metod4(int count, string text)
{ 
    string result = String.Empty;
    // Цикл фор в котором задется переменная счетчик для перебора действий.
    for (int i = 0; i<count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Metod4(10, "asdf"); // задаем переменную в которой вызываем метод
Console.WriteLine(res);
