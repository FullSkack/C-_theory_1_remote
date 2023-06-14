//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
              +"ежели бы вас послали вместо нашего милого Винценгероде,"
              +"вы бы взяли приступом согласие прусского короля."
              +"Вы так красноречивы. Вы дадите мне чаю?";
// Метод, который в тексе берет старое значение
object Replace(string text, char oldValue, char newVauel)
{
    string result = String.Empty; // переменная результата
    int length = text.Length; // определяем длинну текста

    for(int i = 0; i < length; i++)
    // Цикл перебора элементов строки и замены соответсвующего
    {
        if(text[i] == oldValue) result += $"{newVauel}";
        else result += $"{text[i]}";
    }
    return result;
}

string newText = (string)Replace(text, ' ', '|');
System.Console.WriteLine(newText);

newText = (string)Replace(text, 'к', 'К');
System.Console.WriteLine(newText);

newText = (string)Replace(text, 'С', 'с');
System.Console.WriteLine(newText);

