// Метод перевода типа переменной string в переменную int.
int Shift(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}
// Метод набора массива строк с клавиатуры. 
void CreateArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Console.ReadLine();
    }
}
// Метод вывода массива строк на экран.
void PrintArray(string[] arr)
{
    int size = arr.Length;
    if (size != 0)
    {
        Console.Write("[");
        for (int i = 0; i < arr.Length - 1 ; i++)
        {
            Console.Write($"'{arr[i]}', ");
        }
        Console.Write($"'{arr[arr.Length - 1]}'");
        Console.Write("]");
    }
    else Console.Write("[]");
}
// Метод который из имеющегося массива строк формирует массив из строк, длина которого меньше либо равна 3 символам.
string[] SelectionArray(string[] inputArray)
{
    int size = inputArray.Length;
    int outputArraySize = 0;
    int index1 = 0;
    int index2 = 0;
    for (index1 = 0; index1 < size; index1++)
    {
        if (inputArray[index1].Length <= 3) outputArraySize++;
    }
    string[] outputArray = new string[outputArraySize];
    for (index1 = 0; index1 < size; index1++)
    {
        if (inputArray[index1].Length <= 3) outputArray[index2++] = inputArray[index1];
    }
    return outputArray;

}

int size = Shift("Длина массива => ");
string[] inputArray = new string[size];
Console.WriteLine("Ввод массива => ");
CreateArray(inputArray);
PrintArray(inputArray);
string[] outputArray = SelectionArray(inputArray);
Console.Write(" -> ");
PrintArray(outputArray);