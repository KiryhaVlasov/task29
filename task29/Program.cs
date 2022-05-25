Console.WriteLine("введите длину массива");
int n = Convert.ToInt32(Console.ReadLine());
int[] mass = new int[n];
void FillArray(int[] massive)
{
    for (int i = 0; i < mass.Length; i++)
    {
        Console.WriteLine($"введите {i+1} цифру массива ");
        mass[i] =int.Parse(Console.ReadLine());
    }
}
void PrintArray(int[] massive)
{
    for (int i = 0; i < mass.Length; i++)
    {
        Console.Write($"{mass[i]} ");
        
    }
}

FillArray(mass);
Console.Write("[");
PrintArray(mass);
Console.Write("]");