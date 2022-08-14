/*
Семинар 5. Массивы.
Вариант 1. Из семинара 4 - генерация и отображение массива
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
        
        return newArray;
} 

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

int[] binaryArray = CreateRandomArray(8, 0, 1);
ShowArray(binaryArray);
______________________

//Task 1. Необъодимо задать массив из 12 элементов, заполнить случайными числами 
//из промежутка, найти сумму отрицательныъ и положительных элементов массива

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
        
        return newArray;
} 

int[] CreateArray(int size)
{
    int[] newArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} element of {size}: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

int SumOfPositive(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) sum += array[i];
    }
    return sum;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input positive min value of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input positive max value of elements: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);
Console.WriteLine("Sum of positive elements is: " + SumOfPositive(array));
__________________________
*/
// Task 2. Необходимо написать программу, с заменой элементов массива, при этом
// положительные элементы надо заменить на соответствующие отрицатеьные и наоборот
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
        
        return newArray;
} 

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

int[] InvertArray(int[] array)
{
    for(int i = 0; i < array.Length; i++) array[i] *= (-1); 
    return array; 
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input positive min value of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input positive max value of elements: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);
array = InvertArray(array);
ShowArray(array);
___________________

// Task 3. Необходимо задать массив и написать программу, чтобы отпределить 
// присутствует ли указанное число в массиве

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
        
        return newArray;
} 

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

bool SearchInArr(int num, int[] array)
{
    for(int i = 0; i < array.Length; i++) 
        if(array[i] == num) return true;
        
        else return false;
}

int[] newarray = CreateRandomArray(10, 0, 10);
ShowArray(newarray);
Console.Write("Input number to check: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write(SearchInArr(num, newarray));

// Task 4. Необходимо задать одномерный массив из 12 случайных чисел
// и найти количество элементов, лежащих в отрезке от 10 до 99 
// (то есть все двузначные числа)

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
        
        return newArray;
} 

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

int Count(int[] array, int min, int max)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] >= 10 && array[i] <= 99) count = count + 1;
    }
    return count;
}
Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input positive min value of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input positive max value of elements: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);
int count = Count(array, min, max);
Console.Write($"Количество двузначных занчений в массиве составляет: {count}");
*/
//Task 5. Необходимо найти произведение пар чисел в одномерном массиве,
// пары - первый и последний, второй и предпоследний
// результат записать в новом массиве

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
        
        return newArray;
} 

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

int[] NewArray(int[] array)
{
    if(array.Length % 2 == 0) 
    {
        int[] result = new int[array.Length/2]; 
        for(int i = 0; i < result.Length; i++)
        {
            result[i] = array[i] * array[array.Length - 1 - i];
        }
        return result;
    }
    else 
    {
        int[] result = new int[array.Length/2 + 1]; 
        for(int i = 0; i < result.Length - 1; i++)
        {
            result[i] = array[i] * array[array.Length - 1 - i];
        }
        result[result.Length - 1] = array[result.Length - 1];
        return result; 
    }
        
    
} 
Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input positive min value of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input positive max value of elements: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);
int[] result = NewArray(array);
ShowArray(result);