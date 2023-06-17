int Prompt(string message)
{
    Console.WriteLine(message);
    string rawInput = Console.ReadLine();
    int result = int.Parse(rawInput);
    return result;
}
int[] GenerateArray(int Length)
{
    int[] array = new int[Length]; 
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(100, 999); 
    }
    return array;
}
void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, "); 
    }
    System.Console.Write($"{array[array.Length - 1]}");
    System.Console.WriteLine("]");
}
void PrintEven(int[] array)
{
    int count=0;
    for (int i=0;i<array.Length;i++)
    {
        if (array[i]%2==0){count++;}
    }
    Console.WriteLine(count);

}
Console.Clear();
int length = Prompt("Введите длину массива: ");
int[] array = GenerateArray(length); 
PrintArray(array);
PrintEven(array);