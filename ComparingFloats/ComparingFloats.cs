/*
 * Write a program that safely compares two floating-point numbers (double) with precision eps = 0.000001.

Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the 
floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other
than a fixed constant eps.
 * */

using System;


class ComparingFloats
{
    static void Main()
    {
        double firstNumber = new double();
        double secondNumber = new double();
        double difference = new double();
        double eps = 0.000001;

        firstNumber = double.Parse(Console.ReadLine());
        secondNumber = double.Parse(Console.ReadLine());

        difference = Math.Max(firstNumber, secondNumber) - Math.Min(firstNumber, secondNumber);

        if (difference < eps)
        {
            Console.WriteLine("true");
        }
        else if (difference >= eps)
        {
            Console.WriteLine("false");
        }
    }
}
