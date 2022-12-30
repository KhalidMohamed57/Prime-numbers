using System;
class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("ENTER 1St NUMBER");
        int a = int.Parse(Console.ReadLine()!);
        Console.WriteLine("ENTER 2Scd NUMBER");
        int s = int.Parse(Console.ReadLine()!);
        for (int i = a; i <= s; i++)
        { int divisors = 0;
            for ( int j=1;j<=i; j++ )
            if (i%j==0) { divisors++; }
            if (divisors == 2)
            {
                Console.WriteLine(i + "is prime number");
            }




        }

    }
}
