string[] initialArray = FillStringArray();
int elementMaxLength = 3;
string[] newArray = new string[GetArrayLength(initialArray, elementMaxLength)];
newArray = CreateNewArrayWithCharacterLimit(initialArray, newArray, elementMaxLength);

Console.WriteLine("первоночальный массив:");
PrintArray(initialArray);
Console.WriteLine($"новый массив с длинной элементов меньше или равно {elementMaxLength}:");
PrintArray(newArray);

string[] FillStringArray()
{
    string[] arr;
    Console.Write("введите элементы массива через запятую (,) : ");
    string str = Console.ReadLine()!;
    arr = str.Split(',');
    return arr;
}

int GetArrayLength(string[] arr, int n)
{
    int elementCount = 0;
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        if (arr[i].Length <= n) elementCount++;
    }
    return elementCount;
}

string[] CreateNewArrayWithCharacterLimit(string[] arr, string[] newArr, int maxLen)
{
    int count = 0;
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        if (arr[i].Length <= maxLen) 
        {
            newArr[count] = arr[i];
            count++;
        }
    }
    return newArr;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine("\b" + "\b" + "]");
}
