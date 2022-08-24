string[] mainArray = new string[5]; 
string[] resultArray = new string[mainArray.Length];

Console.WriteLine("Введите строки массива: ");
for(int i = 0; i < mainArray.Length; i++)
{
   mainArray[i] = Console.ReadLine();
}
Console.WriteLine();
Console.WriteLine("Исходный массив: ");
Console.WriteLine(string.Join(" ", mainArray));
Console.WriteLine();

void FillResultArray(string[] firstArray, string[] secondArray)
{
    int count = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {
    if(firstArray[i].Length <= 3)
        {
        secondArray[count] = firstArray[i];
        count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

FillResultArray(mainArray, resultArray);

Console.WriteLine("Массив строк с длиной <=3: ");

PrintArray(resultArray);