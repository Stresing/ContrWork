void PrintArray(char[] collection) // вывод Массива
{
    Console.Write("[" + string.Join("", collection) + "]");
}

Console.WriteLine("Введите данные");
string? str = Console.ReadLine(); // пользователь вводит данные цифры/слова + проверка на null
char[] customArray = new char[str.Length]; //  Преобразовываем строку в массив с наименованием customArray.
for (int i = 0; i < str.Length; i++)
{
    customArray[i] = str[i];
}

if (customArray.Length <= 3) // проверка на количество символов + 
{
    char[] limitArray = new char[customArray.Length];
    for (int i = 0; i < customArray.Length; i++)
    {
        limitArray[i] = customArray[i];
    }
    PrintArray(limitArray);
}