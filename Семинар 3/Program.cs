// Теорема Пифагора: 
// Квадрат гипатинузы равен сумме квадратов катетов

// Для трехмерной модели: длина стороны бедт равна:
// квадрат AB = 

// Метод для извлечения корня квадратного из числа:  
// a = Math.Sqrt(b);


// Задача 1. Необходимо написать программу, которая по заданному номеру четверти,
// показывает возможный диапазон точек в этой четсерти
/*
void ShowDiaposon(int quart)
{
    while(quart < 1 || quart > 4)
    {
        Console.Write("Uncorrect input! Try again here: ");
        quart = Convert.ToInt32(Console.ReadLine());
    }

    if(quart == 1) Console.WriteLine("x > 0, y > 0");
    if(quart == 2) Console.WriteLine("x < 0, y > 0");
    if(quart == 3) Console.WriteLine("x < 0, y < 0");
    if(quart == 4) Console.WriteLine("x > 0, y < 0"); 
}

Console.Write("Input number of quart: ");
int quartNum = Convert.ToInt32(Console.ReadLine());
ShowDiaposon(quartNum);
*/

// Задача 2. Необходимо написать программу, которая принимает на вход координаты 
// точки (x, y), при этом (х != 0, у != 0), возвращает номер четверти, в которой 
// расположена данная точка
/*
int WhichQuater(int x, int y)
{
    int result = 0;
    if(x > 0 && y > 0) result = 1; 
    if(x < 0 && y > 0) result = 2; 
    if(x < 0 && y < 0) result = 3; 
    if(x > 0 && y < 0) result = 4; 
    return result; 
}
 
Console.Write("Input number of x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of y: ");
int y = Convert.ToInt32(Console.ReadLine());
int number;
if(x != 0 && y != 0) 
{
    number = WhichQuater(x, y);
    Console.WriteLine($"Точка находится в {number} четверти");
}
else Console.WriteLine("Точка находится на оси координат");
*/

   
// Задача 3. Необходимо написать программу (метод), 
// которая на вход принимает координаты двух точек и находит расстояние между
// ними в 2D пространстве.

/*
double Dist(double xa, double ya, double xb, double yb)
{
    double dist = Math.Sqrt((xb-xa) * (xb-xa) + (yb-ya)*(yb-ya));
    return dist;
}
Console.Write("Введите координаты x точки А: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты y точки А: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты x точки B: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты y точки B: ");
int yb = Convert.ToInt32(Console.ReadLine());

double dist = Dist(xa, xb, ya, yb);
Console.WriteLine($"Расстояние между точками А и В равно {dist} ");

*/
// Задача 4. Необходимо написать программу, которая на вход принимает число N
// и возвращает последовательность квадратов чисел от 1 до N. 

void Numbers(double num)
{
    int current = 1;
    while(current <= num)
    {
        Console.Write(current*current + " ");
        current++;
    }
}
double check;
Console.Write("Введите положительное число: ");
check = Convert.ToDouble(Console.ReadLine());
if(check < 0) check = check * -1;
Numbers(check);
