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

int[,] CreateRandom2dArray(int rows, int colums, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, colums];

    for(int i = 0; i < rows; i++)  // Внешний цикл, отвечающий за прохождение по строкам (этажам)
    {
        for(int j = 0; j < colums; j++) // Внутренний цикл, отвечающий за прохождение по элементам (квартирам)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
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

int[] ReverseArray(int[] array)
{
    for(int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine(); // это чтобы отделить строки
    }
    Console.WriteLine(); // а это чтобы отделить массив от идущей следуюшией информации
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of colums: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2dArray(m, n, min, max); 
Show2dArray(array);
*/
// Task 2. Необходимо задать двумерный массив размером m & n, каждый элемент в котором находится по формуле 
// a[i, j] = i + j;
/*
int[,] CreateRandom2dArray(int rows, int colums, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, colums];

    for(int i = 0; i < rows; i++)  
    {
        for(int j = 0; j < colums; j++) 
        {
            newArray[i, j] = i + j;
        }
    }
    return newArray;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine(); 
    }
    Console.WriteLine(); 
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of colums: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2dArray(m, n, min, max); 
Show2dArray(array);
*/
// Task 3. Задать двумерный массив, найти элементы, у которых оба индекса четные
// и заменить элементы в них на квадраты

/*
int[,] CreateRandom2dArray1(int rows, int colums, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, colums];

    for(int i = 0; i < rows; i++)  
    {
        for(int j = 0; j < colums; j++) 
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return newArray;
}

void Show2dArray1(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine(); 
    }
    Console.WriteLine(); 
}

int[,] ChangeElements(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i+=2)
    {
        for(int j = 0; j < array.GetLength(1); j+=2)
        {
            array[i, j] = array[i, j] * array[i, j];
        }
    }
    return array;
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of colums: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2dArray1(m, n, min, max); 
Show2dArray1(array);
ChangeElements(array);
Show2dArray1(array);
*/

// Task 4. Задать двумерный массив и найти сумму элементов главной диагонали

int[,] CreateRandom2dArray2(int rows, int colums, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, colums];

    for(int i = 0; i < rows; i++)  
    {
        for(int j = 0; j < colums; j++) 
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return newArray;
}

void Show2dArray2(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine(); 
    }
    Console.WriteLine(); 
}

int SumOfElements(int[,] array)
{
    int sum = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(i == j) sum = sum + array[i, j];
        }
    }
    return sum;
}

int SumOfElements1(int[,] array) // более короткий метод
{
    int sum = 0;
    for(int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
    sum += array[i, i];

    return sum;
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of colums: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2dArray2(m, n, min, max); 
Show2dArray2(array);
Console.Write($"Сумма элементов в главной диагонали равна {SumOfElements(array)}");
