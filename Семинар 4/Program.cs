// Необходимо написать программу, которая на вход принимает 
// число и выдает количество цифр
/*
int NumOfDigits(int num)

{
    int count = 0;

    while(num != 0)
    {
        num /= 10; // num = num / 10
        count++;
    }
    return count;
}

Console.Write("Input integer number: ");
int number = Convert.ToInt32(Console.ReadLine());

int numOfDigits = NumOfDigits(number);
Console.WriteLine($"Number of digits of {number} is {numOfDigits}");
*/
// Задание 2. Написать программу, которая на вход принимает число
// и выдает сумму чисел от единицы до этого числа
/*
int Sum(int n)
{
    int sum = 1;
    int count = 0;
    while(count <= n)
    {
        sum = sum + count;
        count++;
    }
    return sum;
}
Console.Write("Input integer number: ");
int number = Convert.ToInt32(Console.ReadLine());

int sum = Sum(number);
Console.WriteLine($"Sum of {number} is {sum}");

*/
// Задание 3. Написать программу, которая на вход принимает число N
// и выдает произведение чисел до N, кратные 3
/*
int ProductOfNum(int num)
{
    int count = 1;
    int result = 1;
    while(count <= num)
    {
        if(count %3 == 0) result = result * count;
        
    count++;
    }
    return result;
}
Console.Write("Input integer number: ");
int number = Convert.ToInt32(Console.ReadLine());

int pro = ProductOfNum(number);
Console.WriteLine($"Product of {number} is {pro}");
_________________________

// Задание 3. Еще одно решение.
int ResNumber(int num)
{
    int result = 1;
    for(int i = 3; i <= num; i += 3)
    {
        result *= i;
    }
    return result;
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number < 3) Console.WriteLine("Число меньше 3");
else 
{
    int result = ResNumber(number);
    Console.WriteLine($"Произведение чисел от 1 до {number} кратных 3 равно {result}");
}

// Задание 4. Написать программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке
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
*/