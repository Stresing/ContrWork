void PrintArray(string[] collection) // вывод Массива
{
    Console.Write("[" + string.Join(", ", collection) + "]");
}
Console.Clear();
Console.Write("Сколько строк вы хотите внести в массив? ");
int cellMemory = int.Parse(Console.ReadLine());
string[] array = new string[cellMemory];

for (int i = 0; i < cellMemory; i++) // запись строк в массив
{
    Console.Write("Введите строку и нажмите Enter: ");
    string? str = Console.ReadLine();
    array[i] = str;
}
Console.Clear();
Console.Write("Созданный вами массив: ");
PrintArray(array);
int amount = 0;
int count = 0;
System.Console.WriteLine();
for (int i = 0; i < cellMemory; i++)// определение количество ячеек для создания массива
{
    if (array[i].Length<=3)
    {
       amount ++; 
    }
}
string[] limitArray = new string[amount]; 
for (int i = 0; i < array.Length; i++) // заполнение массива значениями подходящие под условия 
{
    if (array[i].Length <=3)
    {
        limitArray[count] = array[i];
        count ++;
    }
}

System.Console.WriteLine();
Console.Write("Новый массив с 3мя и меньше, символами: ");
PrintArray(limitArray);