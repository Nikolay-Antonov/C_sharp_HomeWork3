// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 


// 14212 -> нет
// 
// 12821 -> да
// 
// 23432 -> да
// НЕЛЬЗЯ ИСПОЛЬЗОВАТЬ СТРОКИ

Console.Write("введите пятизначное число ");
int number = Convert.ToInt32(Console.ReadLine());

PalindromOrNot(number);

void PalindromOrNot(int number)
{
    if (number / 10000 == number % 10)
    {
        if (number % 10000 / 1000 == number % 100 / 10)
        {
            System.Console.WriteLine("палиндром");
        }
        else
            System.Console.WriteLine("не палиндром");
    }
    else
        System.Console.WriteLine("не палиндром");
}
