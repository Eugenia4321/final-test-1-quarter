using System.ComponentModel.DataAnnotations;


Console.Write("Количество элементов массива = ");
int arraySize = int.Parse(Console.ReadLine());
string[] inputArray = CreateArray(arraySize);
FillArray(inputArray);
Console.WriteLine("Входной массив :");
PrintArray(inputArray);
string[] outputArray = CreateArray(0);
string[] resultArray= FoundArray(inputArray, outputArray);
Console.WriteLine("Массив с элементами, длина которых меньше 3:");
PrintArray(resultArray);





string[] FoundArray(string[] inputArray, string[] outputArray, int itemSize=3)
    {
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= itemSize)
        {         
            Array.Resize(ref outputArray, outputArray.Length + 1);                      
            outputArray[outputArray.Length-1]=inputArray[i];
                }
    }
        
        return outputArray;
    }
string[] FillArray(string[] inputArray)
{
    for (int i = 0; i < inputArray.Length; i++)
    {
        Console.Write($"Введите {i+1} элемент массива = ") ;
        inputArray[i] = Console.ReadLine();
    }
    return inputArray;
}
string[] CreateArray(int arraySize)
{
    string[] array = new string[arraySize];
    return array;
}
void PrintArray(string[] array)
{
    if (array.Length == 0)
        Console.Write("[]");
    else
    {
        int count = array.Length;
        Console.Write("[");
        for (int i = 0; i < count; i++)
        {

            Console.Write(array[i]);
            if (i != count - 1)
                Console.Write(", ");
            else
                Console.WriteLine("]");

        }
    }
    Console.WriteLine();
}