// Task 1.
// Необходимо задать число N и вывести все числа в промежутке от 1 до N.
/*
void ShowNums(int n)
{
    Console.Write(n + " ");
    if(n != 1) ShowNums(n - 1);
}

Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

ShowNums(num);
*/

// Task 2.
// Написать программу, которая будет принимать на вход число и возвращает сумму его сумму его цифр.
/*
int SumOfDigits(int n)
{
    if(n != 0) return n % 10 + SumOfDigits(n / 10);
    return 0;
}

Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Sum of Digits in {num} is {SumOfDigits(num)}");
*/

// Tasl 3. 
// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
/*
void AllNaturals(int m, int n)
{
    if(m > n)
    {
        int temp = n;
        n = m;
        m = temp;
    }
    
    if(m != n) AllNaturals(m, n-1);
        Console.Write(n + " ");
}

Console.WriteLine("Input number m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number n: ");
int n = Convert.ToInt32(Console.ReadLine());
AllNaturals(m, n);
*/

// Task 4. 
// Напишите программу, 
// которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии

int Stepen(int a, int b)
{
    if(b!=0) return a * Stepen(a, b-1);
    return 1;
}

Console.WriteLine("Input number a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Число {a} в степени {b} =  {Stepen(a, b)}");