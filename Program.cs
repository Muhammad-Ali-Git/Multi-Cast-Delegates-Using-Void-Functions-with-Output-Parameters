// See https://aka.ms/new-console-template for more information
using System;

public delegate void Sample(out int Integer);

public class Ali
{
    public static void Main()
    {
        Console.WriteLine("This Program Prints output of Multi-Cast Delegates.");
        Console.WriteLine("A Multi-Cast Delegate points to more than one function.");
        Console.WriteLine("\n --------------------------------------------------------- \n");
        
        Console.WriteLine("Method-I: Create Multiple Deligates");
        Sample S1, S2, S3;
        S1 = new Sample(Method1);
        S2 = new Sample(Method2);

        S3 = S1 + S2;  // Multi-Cast Delegate is formed by chaining (adding) delegates together.
        int result1 = 0;
        S3(out result1);   // Multi-Cast Delegate
        Console.WriteLine("Delegate Returned Value = {0}", result1);
        Console.WriteLine("\n --------------------------------------------------------- \n");

        Console.WriteLine("Method-I: Create Single Deligate");
        Sample D = new Sample(Method1);

        D = D + Method2;
        int result2 = 0;
        D(out result2);   // Multi-Cast Delegate
        Console.WriteLine("Delegate Returned Value = {0}", result2);
    }

    public static void Method1(out int Number1)
    {
        Number1 = 1;
    }
    public static void Method2(out int Number2)
    {
        Number2 = 2;
    }
}