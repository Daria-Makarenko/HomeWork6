//  Домашняя работа 6

// Задача 1 - Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        //Console.WriteLine($"array[{i + 1}] is {array[i]}");
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.Write("Input a number elements: ");
 int size = Convert.ToInt32(Console.ReadLine());
 Console.Write("Input a min possible value: ");
 int min = Convert.ToInt32(Console.ReadLine());
 Console.Write("Input a max possible value: ");
 int max = Convert.ToInt32(Console.ReadLine());
 
 int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray); 
*/
/*
int[] CreateRandomArray(int m)
{
    int[] array = new int[m];

    for(int i = 0; i < m; i++)
    {
        Console.WriteLine("Input a number: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
Console.Write("Input size: ");
int m = Convert.ToInt32(Console.ReadLine());

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        //Console.WriteLine($"array[{i + 1}] is {array[i]}");
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] myArray = CreateRandomArray(m);
ShowArray(myArray); 

int Quantity(int[] array)
{
   
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i]> 0)
        count+=1;
    }
    return count;
}

int result = Quantity(myArray);
Console.WriteLine($"Colichestvo chisel bolshe 0 ravno: {result}");
*/

// Задача 2 - Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
/*
void InterPoint(double b1, double k1, double b2, double k2)
{
    double x = (b1 - b2)/(k2 - k1);
    double y = (k2 * b1 - k1 * b2)/(k2 - k1);
    if(k1==k2)
    Console.WriteLine("Заданные прямые не пересекаются");
    else 
    Console.WriteLine($"Точка пересечения прямых: ({x}; {y})");
}

Console.Write("Input b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

InterPoint(b1 ,k1 ,b2, k2);
*/