// Условие: является ли первое вводимое число квадратом второго? 
int num1, num2;

Console.Write("input first integer number: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input second integer number: ");
num2 = Convert.ToInt32(Console.ReadLine());

if(num1 == num2 * num2)
    Console.WriteLine("Yes"); // Если присутствует только одна строка, то фигурные скобки можно не ставить
else 
{
    Console.WriteLine("No");
}