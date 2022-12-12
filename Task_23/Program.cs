/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.*/


Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
int digit = 1;
int[] array = new int[number];
    while (number > count)
    {
        array[count] = Convert.ToInt32(Math.Pow(digit, 3));
        count++;
        digit++;
    }
var result = string.Join("-", array);

Console.WriteLine(result);
