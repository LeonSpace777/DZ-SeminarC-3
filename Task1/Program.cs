// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
string text = Console.ReadLine();
int length = text.Length;

if (length == 5)
{
    if (text[0] == text[4] && text[1] == text[3])
    {
        System.Console.Write(text);
        Console.WriteLine(" Полиндром");
    }
    else
    {
        System.Console.Write(text);
        Console.WriteLine(" не палиндром");
    }
}
else
{
    Console.WriteLine("Вы ввели не пятизначное число");
}