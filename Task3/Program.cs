// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int num = 0;
int count = 1;
double a = 0;

Console.WriteLine("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());

if (num > 0)
{
    while (count <= num)
    {
        a = Math.Pow(count, 3);
        System.Console.WriteLine(a);
        count = count + 1;
    }
}
else
{
    System.Console.WriteLine("Введено некорректное число");
}