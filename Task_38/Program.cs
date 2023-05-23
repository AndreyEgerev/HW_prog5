// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// функция ввода числа и возврата в числовом формате
int GetNumberInt( string text)
{
    Console.Write(text);
    string value = Console.ReadLine ();
    int number = Convert.ToInt32(value);
    return number;
}

//Функция поиска минимального элемента
double FindMinNumber(double[] arr)
{
	double minValue = arr[0];
	for (int i=0; i<arr.Length-1; i++)
	{
		if (minValue > arr[i+1])
		{
			minValue = arr[i+1];
		}
	}
    Console.WriteLine(minValue);
	return minValue;
}
//Функция нахождения максимального элемента
double FindMaxNumber(double[] arr)
{
	double maxValue = arr[0];
	for (int i=0; i<arr.Length-1; i++)
	{
		if (maxValue < arr[i+1])
		{
			maxValue = arr[i+1];
		}
	}
    Console.WriteLine(maxValue);
	return maxValue;
}

//Функция генерации массива вещественными числами в заданном диапазоне
double[] GetArray(int size, int minValue, int maxValue)
{
    double[] res = new double[size];
    Console.Write("[ ");
    for (int i = 0; i < size; i++)
    {
        //res[i] = new Random().Next(minValue, maxValue);
        res[i] = Math.Round(new Random().NextDouble() * (maxValue - minValue) + minValue,2);
        Console.Write($"{res[i]}  ");
    }
    Console.WriteLine(" ] ");
    return res;
}
// Приветствие
Console.WriteLine("Программа поиска разницы между максмальным и минимальным элементами в массиве");
//Ввод размера массива
int sizeArray = GetNumberInt("Введите размер массива - ");
//Генерация массива с выводом на экран
double[] massiv = GetArray (sizeArray,-10,10);
//Вывод результата
Console.WriteLine($"Разница между максимальным и минимальным элементом массива - {FindMaxNumber(massiv) - FindMinNumber(massiv)}");