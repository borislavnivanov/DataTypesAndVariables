/*
 * Create a program that assigns null values to an integer and to a double variable.

Try to print these variables at the console.
Try to add some number or the null literal to these variables and print the result.
 * */

using System;


class NullValuesArithmetic
{
    static void Main()
    {
        int? integer = new int();
        double? number = new double();

        Console.WriteLine("integer = {0}, double ={0}", integer, number);

        integer = 10;
        number = 10.255;

        Console.WriteLine("integer = {0}, double ={0}", integer, number);

        integer = null;
        number = null;

        Console.WriteLine("integer = {0}, double ={0}", integer, number);



    }
}