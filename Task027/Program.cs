// Напишите программу, которая принимает на вход число и выдает сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

class Program
{   
    static void Main(string[] args)
    {
    Console.Write("Введите число: ");
    var n = Convert.ToInt32(Console.ReadLine());
    var sum = 0;
    while(n > 0)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine(sum);
    }
}