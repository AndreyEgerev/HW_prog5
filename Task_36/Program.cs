// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// функция ввода числа и возврата в числовом формате
int GetNumberInt( string text)
{
    Console.Write(text);
    string value = Console.ReadLine ();
    int number = Convert.ToInt32(value);
    return number;
}

//Функция генерации массива целыми числами
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

//Функция поиска суммы нечетных элементов массива
int FindSumOddNumber (int[] arr)
{
	int summOdd = 0;
	for (int i=1; i<arr.Length; i = i + 2 )
	{
		summOdd = summOdd + arr[i];
	}
	return summOdd;
}

// Приветствие
Console.WriteLine("Программа поиска суммы чисел в массиве на нечетных позициях");
//Ввод размера массива
int sizeArray = GetNumberInt("Введите размер массива - ");
//Генерация массива
int[] massiv = GetArray (sizeArray,-9,10);
//Вычисление суммы
int summOddNumber = FindSumOddNumber(massiv);
//Вывод на экран
Console.WriteLine($"Сумма нечетных элементов массива - {summOddNumber}");
