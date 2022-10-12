// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с
// клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется
// пользоваться коллекциями, лучше обойтись исключительно массивами. 

string[] arr1 = new string[] {"zero", "one1", "two", "three", "four", "five", "7", "ten"};
string[] arr2 = new string[] {"Berlin", "Moscow", "Kaliningrad"};
int temp = 3;

string[] TransformArray (string[] array)
{
    int count = default;
    int length = array.Length;
    string[] result = new string[length];
    for (int i = 0; i < length; i++)
    {
        if (array[i].Length <= temp)
        {
            result[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref result, count);
    return result;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length ; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

void PrintResult(string[] array)
	{
		PrintArray(array);
		string[] resultArray = TransformArray(array);
		Console.Write(" -> ");
		PrintArray(resultArray);
	}

Console.WriteLine();
Console.Write("Массив 1: ");
PrintResult(arr1);
Console.WriteLine();
Console.Write("Массив 2: ");
PrintResult(arr2);
Console.WriteLine();
Console.WriteLine();