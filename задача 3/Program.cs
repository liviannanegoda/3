//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
Console.Clear();
Console.WriteLine("Введите число N: ");
string N = Console.ReadLine();
int len = N.Length;
if (len == 5)
{
    if (N[0] == N[4] && N[1] == N[3])
    {
        Console.WriteLine($"{N} - Палиндром");
    }
    else
    {
        Console.WriteLine($"{N} - Не палиндром");
    }
}
else {
    Console.WriteLine($"{N} - не является пятизначным числом");
}