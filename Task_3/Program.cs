﻿internal class Task_3
{
    private static void Main(string[] args)
    {
        Console.Write("Input number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0)
        Console.WriteLine(number + " --> " + "Yes");
        else 
        Console.WriteLine(number + " --> " + "No");
    }
}