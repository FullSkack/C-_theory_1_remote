// метод принимает на вход две переменные, 
//на выхож дает значение с типом string
string Metod4(int count, string text)
{ 
    int i = 0;
    // переменная в которую записываем результ, изначльно пустая строка
    string result = String.Empty;
    while (i<count) 
    // цикл для компановки текста count раз
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Metod4(10, "asdf"); // задаем переменную в которой вызываем метод
Console.WriteLine(res);