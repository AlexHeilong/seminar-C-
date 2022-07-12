/*  Task 2
 программа, которая на вход принимает число N, а на выходе показывает все целые числа от -N до N.

Console.Write("input positive integer number: ");
int num = Convert.ToInt32(Console.ReadLine()); // производную можно вводить непосредственно в конструкцию

int current = num * (-1);

while(current <= num)
{
    Console.Write(current + " ");
    current++;
}
*/
// Task 3. Программа, которая принимает на вход трехзначное число. На выходе показывает последнюю цифру этого числа
/*
1234 / 100 -> 12 если нужно отсечь последние разряды, то нужно делить на 10 в нужной степени 
                    (2 последних разряда - это 10 во второй степени)
1234 / 10 -> 123 если отсечь один последний разряд, то на 10 в первой

1234 % 10 -> 4 находим остаток от деления, если нужен последний элемент, то на 10
1234 % 100 -> 34  если два последних то на 10 во сторой степени = 100, если 3 последних, то на 10 в 3 степени 
1234 / 10 % 100 -> 23 вычленяем середину - (/10) сперва отсекаем последний элемент (4), 
                      потом (% 100) первый элемент.  Оставляем серединку - 23


// Как получить трехзначное число из многозначного?
int a = 1234512345;

while(a > 999)
{
    a /= 10; //  тоже самое a = a/10
}
Console.Write(a);

//Task 3 Решение

Console.Write("input integer number: ");
int num = Convert.ToInt32(Console.ReadLine()); 

Console.Write(num % 10);

Task 4. Программа, которая будет выдавать название дня недели по заданному номеру.
Task 5. Программа, которая на вход принимает число, а на возвращает ее квадрат
*/
// Task 4. Solve

Console.Write("input integer number: ");
int num = Convert.ToInt32(Console.ReadLine()); 
if(num == 1) Console.WriteLine(" Понедельник ");
if(num == 2) Console.WriteLine(" Вторник ");
if(num == 3) Console.WriteLine(" Среда ");
if(num == 4) Console.WriteLine(" Четверг ");
if(num == 5) Console.WriteLine(" Пятница ");
if(num == 6) Console.WriteLine(" Суббота ");
if(num == 7) Console.WriteLine(" Воскресенье ");
else Console.WriteLine(" Такого дня недели не существует");

/* Task 5. Solve
Console.Write("input integer number: ");
int num = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine(num = num * num);
*/