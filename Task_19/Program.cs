/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.*/

Console.WriteLine("Введите число");
string number = Console.ReadLine();
char[] array = number.ToCharArray();
int length = array.Length;
if (length == 5)
{     
     Array.Reverse(array);
    string revnum = new string(array);
    if (number == revnum)
        Console.WriteLine("Палиндром");
    else
        Console.WriteLine("Не палиндром");
}
else
    Console.WriteLine("Введите пятизначное число");
