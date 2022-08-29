// Task 1. 
// Задать двумерный массив. Написать программу, которая поменяет местами первую 
// и последнюю строки массива.  
/*
int[,] CreateRandom2dArray(int rows, int colums, int minValue, int maxValue)
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

int[,] ChangeRows(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int temp = array[0, j];
        array[0, j] = array[array.GetLength(0) -1, j];
        array[array.GetLength(0) -1, j] = temp;
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

int[,] array = CreateRandom2dArray(m, n, min, max); 
Show2dArray(array);
Show2dArray(ChangeRows(array));
*/
// Task 2.
// Задать двумерный массив. Написать программу, которая поменяет местами строки со столбцами.
// Если это невозможно, программа должна вывести сообщение для пользователя
/*
int[,] CreateRandom2dArray(int rows, int colums, int minValue, int maxValue)
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

int[,] ReplaceRowsColums(int[,] array)
{
    int[,] newArray = new int[array.GetLength(0), array.GetLength(1)]; 
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            newArray[j, i] = array[i, j];
        }
    }   
        return newArray;
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
if(array.GetLength(0) != array.GetLength(1))
    Console.WriteLine("not square array");
else Show2dArray(ReplaceRowsColums(array));
*/
// Task 3.
// Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен 
// наименьщий элемент
/*
int[,] CreateRandom2dArray(int rows, int colums, int minValue, int maxValue)
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

int[,] CutArray(int[,] array)
{
    int iMin = 0, jMin = 0;
    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1]; // создаем новый массив, 
    // в котором уже не будет одного столбца и одной строки
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i, j] < array[iMin, jMin])
            {
                iMin = i;
                jMin = j;
            }
        }
    }   
    for(int i = 0, m = 0; i < array.GetLength(0); i++, m++)
    {
        if(i == iMin) i++;
        for(int j = 0, n = 0; j < array.GetLength(1); j++, n++)
        {
            if(j == jMin) j++;
            newArray[m, n] = array[i, j];
        }
    }
    return newArray;
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
Show2dArray(CutArray(array));
*/