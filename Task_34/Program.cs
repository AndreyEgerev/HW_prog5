// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// функция ввода числа и возврата в числовом формате
int GetNumberInt( string text)
{
    Console.Write(text);
    string value = Console.ReadLine ();
    int number = Convert.ToInt32(value);
    return number;
}

//Функция поиска четных чисел
int FindEvenNumber (int[] arr)
{
	int countEven = 0;
	for (int i=0; i<arr.Length; i++ )
	{
		
		if ( arr[i] % 2 == 0 )
		{
			countEven++;
		}
	}
	return countEven;
}

//Генерация массива целыми числами
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    Console.Write("[ ");
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
        Console.Write($"{res[i]} ");
    }
    Console.WriteLine(" ] ");
    return res;
}

//Вывод массива
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }

}

// Приветствие
Console.WriteLine("Программа поиска четных чисел в массиве из трехзначных чисел");
//Ввод размера массива
int sizeArray = GetNumberInt("Введите размер массива - ");
//Генерация массива
int[] massiv = GetArray (sizeArray,100,1000);
//Вывод массива на экран
//PrintArray(massiv);
//поиск четных чисел
int countEven = FindEvenNumber(massiv);

if (countEven == 0)
{
	Console.WriteLine("В массиве нет четных чисел");
}
else
{
	Console.WriteLine($"В массиве {countEven} четных чисел");
}