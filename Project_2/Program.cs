// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

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

int Check(int num)
{
    int count = 0;
    while(num/10 > 0)
    {
        num=num/10;
        count++;
    }
    return count;
}
double Sum(int number, int count)
{
    double sum = 0;
    int del = Convert.ToInt32(Math.Pow(10,count));
    while(number>0)
    {
        sum = sum + number/del;
        number%=del;
        del/=10;        
    }
    return sum;
}

int number = GetNumber("Введите число:");
int count = Check(number);

double sum = Sum(number,count);
Console.WriteLine($"Сумма чисел числа {number} = {sum}");