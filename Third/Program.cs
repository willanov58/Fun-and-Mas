int Prompt(string message)
{
    Console.WriteLine(message);
    string rawInput = Console.ReadLine();
    int result = int.Parse(rawInput);
    return result;
}
double[] GenerateArray(int Length)
{
    double[] array = new double[Length]; 
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(-100,100)*0.1; 
    }
    return array;
}
void PrintArray(double[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, "); 
    }
    System.Console.Write($"{array[array.Length - 1]}");
    System.Console.WriteLine("]");
}
void DifferOfMaxAndMin(double[] array)
{
    double min=1000;
    double max=0;
    for (int i=0;i<array.Length;i++)
    {
        if(array[i]>max){max=array[i];}

        if(array[i]<min){min=array[i];}
        
    }
    Console.WriteLine(max);
    Console.WriteLine(min);
    Console.WriteLine(max-min);

}
Console.Clear();
int length = Prompt("Введите длину массива: ");
double[] array = GenerateArray(length); 
PrintArray(array);
DifferOfMaxAndMin(array);