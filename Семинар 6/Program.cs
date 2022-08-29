// Task 1. Необходимо написать программу, которая перевернет одномерный массив

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

*/
/*
// Выше представлен метод, который также расписан ниже, но в более удобоворимой форме
// По сути, это два варианта одного и того же метода
int[] ReverseArray(int[] array)
{
    for(int i = 0; i < array.Length/2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 -i];
        array[array.Length - 1 -i] = temp;
    }
    return array;
}
*/
/*
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}


Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input positive min value of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input positive max value of elements: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);

// как сгенерировать рандомное вещественное число?
double number = new Random().Next(1, 10) + new Random().NextDouble();
// Либо это же выражение, можно написать вот так:
//Random rand = new Random();
//double number = rand.Next(1, 10) + rand.NextDouble();

_________________
*/
// Task 2. Необходимо написать программу, которая  принимает на вход 3 числа и проверяет, может ли существовать 
// треугольник со сторонами такой длины? Помощь (условие): каждая из сторон должна быть строго меньше
// суммы двух других
/*
bool CheckTriangle (int a, int b, int c)
{
    return a < b + c && b < a + c && c < a + b;
}
*/
// Task 3. Написать метод, который на вход берет число, а возвращает его двоичное представление
/*
string Convert(int a)
{
    string result = string.Empty;

    while(a != 0)
    {
        result = a % 2 + result;
        a /= 2;
    }
    return result;
}
Console.WriteLine(Convert(50));

// Task 4. Не используя реккурсию, вывести N чисел фибоначчи (первые два числа = 0 и 1)
int[] Fibonacci(int size, int a, int b)
{
    int[] result = new int[size];
    result[0] = a;
    result[1] = b;

    for(int i = 2; i < size; i++)
    {
        result[i] = result[i-1] + result[i-2];
    }
    return result;
}
ShowArray(Fibonacci(5, 1, 2));
*/



