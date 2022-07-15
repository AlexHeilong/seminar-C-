// Task 1.

/* Напишите программу, которая выводит случайное двузначное число из отрезка от 0 до 99
 и показывает наибольшую цифру этого числа

Метод прописывается отдельно от основной программы. Это полноценная подпрограмма, 
которая может принимать данные (агрументы) на вход и выводить данные

- int - сперва указываем тип данных, который вернется в итоге
- FindBeggerDigit() - название метода (даем сами). Чаще методы начинаются с большой буквы,
в отличии от переменной/ 
- () - в круглых скобках указываются аргументы (на вход), которые данный метод должен обрабатывать.
- return - при возвращаемом методе, означает завершение этого метода и возвращении
полученного значения (int - в данном случае). При этом, return должно быть столько, 
сколько полученных вариантов.

int FindBeggerDigit(int num)
{
    int ed = num % 10; // второй вариант с одним return, но доп переменной max
    int dec = num / 10; 
    int max;

    if(ed > dec) max = ed; 
    else  max = dec; 
    
    return max;
}

int FindBeggerDigit(int num)
{
    int ed = num % 10; // для получения единиц
    int dec = num / 10; // для получения десяток

    if(ed > dec) return ed; // если единицы больше,чем десятки, то возвращаем ед
    else return dec; // в противном случае, возвращаем десятки
}

int FindBiggerDigit(int num)
{
    int ed = num % 10; // второй вариант с одним return, но доп переменной max
    int dec = num / 10; 
    int max;

    if(ed > dec) max = ed; 
    else  max = dec; 
    
    return max;
}

void FindBiggerDigitVoid(int num)
{
    int ed = num % 10; 
    int dec = num / 10; 
    int max;

    if(ed > dec) max = ed; 
    else  max = dec; 

    Console.WriteLine(max);
}

int number = new Random().Next(10, 100);
int digit = FindBiggerDigit(number);


Console.WriteLine($"Bigger digit of {number} is {digit}");
FindBiggerDigitVoid(38);

Console.WriteLine($"Bigger digit of {number} is {digit}");
Console.WriteLine("Bigger digit of "+ number + " is " + digit);
// - $ - Позволяет записать текст ("")не прерываясь (+), при этом помещая переменные в {}
// Вышеописанный - это возвратный метод (return)
// Ниже - безвозвратный вариант

//int number = new Random().Next(10, 100);
// int digit = FindBiggerDigit(number);

//_________________________
//Task 2.
// Написать программу, которая принимает два числа и выводит, является ли второе число кратно первому
// Задача на bool

bool isKratno(int n1, int n2)
{
    if(n1 % n2 == 0) return true;
    else return false;
}

Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool kratno = isKratno(num1, num2);

Console.WriteLine(kratno);

__________________________________

// Task 3. 
// Необходимо написать программу, которая вводит случайное трехзначное число и 
// удаляет вторую цифру данного числа
//________________________________________

int DeleteSecondDigit(int num)
{
    int ed = num % 10; 
    int hun = num / 100; 
    
    return hun * 10 + ed; 
}
    
    int number = new Random().Next(100, 1000);
    int digit = DeleteSecondDigit(number);

Console.WriteLine(number);
Console.WriteLine(digit);

//________________________________________
// Task 4.
// Необходимо написать программу, которая принимает на вход число и проверяет
// кратно ли оно одновременно 7 и 23
bool isKratno(int n)
{
    if(n % 7 == 0 && n % 23 ==0) return true;
    else return false;
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

bool kratno = isKratno(num);

Console.WriteLine(kratno);
________________________________________
// Task 5.
// Необходимо написать программу, которая принимает на вход два числа и проверяет
// является ли одно число квадратом другого числа

bool isKvadrat(int n1, int n2)
{
    if(n2 / n1 == n1) return true;
    else return false;
}

Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool kvadrat = isKvadrat(num1, num2);

Console.WriteLine(kvadrat);
______________________________________
*/
