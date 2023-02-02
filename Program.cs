

//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
int bit_depth(ulong ul) //Определим разрядность числа
{
    int k = 0;
    while(ul>0)
    {
        ul = ul/10;
        k++;
    }

    return k;
}


bool isPol(ulong ul)
{
    int p = bit_depth(ul); // Определили роазрядность введённого числа
    
    int k = p-1; //вспомогательная переменная 
   
    while(k>=0) // Производим сравнение симметричных цифр относительно центра числа
    {
        if((ul/Convert.ToUInt64(Math.Pow(10, k))) != ul%10) // Сравниваем первую и последнюю цифры числа
        {
            return false;
        }
        else
        {
            ul = (ul % Convert.ToUInt64(Math.Pow(10, k)))/10; //Отрезаем 2 крайниих цифры по краям и делаем число на 2 разряда меньше
            k = k - 2;
        }
    }
    
    return true;   

}

Console.Write("Input your positive number: ");
ulong numV = Convert.ToUInt64(Console.ReadLine());
if(isPol(numV))
{
    Console.WriteLine("Your number is polinom");
}
else
{
    Console.WriteLine("Your number is not polinom");
}




/*
// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double Distanse(int xa, int ya, int za, int xb, int yb, int zb)
{
    int deltaX = xa -xb;
    int deltaY = ya - yb;
    int deltaZ = za - zb;
    double distAB = Math.Sqrt(deltaX*deltaX + deltaY*deltaY + deltaZ*deltaZ);
    return distAB;
}

// Запрашиваем координаты точки A
Console.Write("Input X coordinate of A: ");
int xAcoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Y coordinate of A: ");
int yAcoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Z coordinate of A: ");
int zAcoord = Convert.ToInt32(Console.ReadLine());

// Запрашиваем координаты точки B
Console.Write("Input X coordinate of B: ");
int xBcoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Y coordinate of B: ");
int yBcoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Z coordinate of B: ");
int zBcoord = Convert.ToInt32(Console.ReadLine());

double distAB = Distanse(xAcoord, yAcoord, zAcoord, xBcoord, yBcoord, zBcoord);
Console.WriteLine($"Distanse between A & B is: {distAB:f3}");
*/



/*
//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void power_of_three(int Numb)
{
    int curr = 1;
    int result;
    while(curr<=Numb)
    {
        result = curr*curr*curr;
        Console.Write($"{result}, ");
        curr++;
    }
    Console.WriteLine("\b\b.");
}

Console.Write("Input your number: ");
int numV = Convert.ToInt32(Console.ReadLine());

if(numV>=1)
{
    Console.Write($"{numV} -> ");
    power_of_three(numV);
}
else Console.WriteLine("Impossible value!");
*/


