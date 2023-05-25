// Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В.
// 3, 5 -> 243
// 2, 4 -> 16

Console.WriteLine("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
int result = A;

for(int i = 1; i < B; i++)
{
    result = result * A;
}
Console.WriteLine(result);

/*
int value = 2;
for (int power = 1; power <=4; power++)
Console.WriteLine($"{value}^{power} = {(long)Math.Pow(value, power)}");
*/
