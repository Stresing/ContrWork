void PrintArray(string[] collection) // вывод Массива
{
    Console.Write("[" + string.Join(", ", collection) + "]");
}

Console.Write("сколько строк вы хотите внести в массив?: ");
int cellMemory = int.Parse(Console.ReadLine());
string[] array = new string[cellMemory];

for (int i = 0; i < cellMemory; i++)
{
    Console.Write("Водите строки поочередно, после каждой строки нажимая на Enter: ");
    string? str = Console.ReadLine();
    array[i] = str;
}
PrintArray(array);
int amount = 0;
int count = 0;
System.Console.WriteLine();
for (int i = 0; i < cellMemory; i++)
{
    if (array[i].Length<=3)
    {
       amount ++; 
    }
}
string[] limitArray = new string[amount];
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <=3)
    {
        limitArray[count] = array[i];
        count ++;
    }
}

System.Console.WriteLine();
PrintArray(limitArray);