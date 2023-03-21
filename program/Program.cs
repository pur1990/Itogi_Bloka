string[] arr1 = new string[5] {"hello", "2", "world", ":-)", "start"};
string[] arr2 = new string[arr1.Length];
void SecondArrayIF(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
    if(arr1[i].Length <= 3)
        {
        arr2[count] = arr1[i];
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
SecondArrayIF(arr1, arr2);
PrintArray(arr2);