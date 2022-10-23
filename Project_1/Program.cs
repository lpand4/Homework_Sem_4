// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetNumber(string msg)
{
    Console.WriteLine(msg);
    int result = 0;
    
    while(true)
    {
        if(int.TryParse(Console.ReadLine(), out int number))
        {
            return number;
        }
        else 
            Console.WriteLine("Вы ввели не число");
    }
    return result;
}
int GetDegree(string msg)
{
    Console.WriteLine(msg);
    int result = 0;
    
    while(true)
    {
        if(int.TryParse(Console.ReadLine(), out int number) && number > 0)
        {
            return number;
        }
        else 
            Console.WriteLine("Вы ввели не натуральную степень");
    }
    return result;
}

int number = GetNumber("Введите число, которое хотите возвести в степень:");
int degree = GetDegree("Введите степень числа:");
int result = 1;
//первый способ
for (int i = 0; i < degree; i++)
{
    result=result*number;
}
Console.WriteLine($"Число {number} в степени {degree} = {result}");
//второй способ
Console.WriteLine($"Число {number} в степени {degree} = {Math.Pow(number,degree)}");