void ArrayToThreeChar(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int count = 0;
        for (int j = 0; j < array[i].Length; j++)
            count++;
        if (count < 4)
            Console.Write($"{array[i]}, ");
    }
}
string[] arr = { "hello", "2", "world", ":-)" };
ArrayToThreeChar(arr);