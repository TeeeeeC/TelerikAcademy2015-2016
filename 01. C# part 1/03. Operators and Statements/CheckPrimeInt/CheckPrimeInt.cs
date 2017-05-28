using System;

class CheckPrimeInt
{
    static void Main()
    {
        /*
         Problem 8. Prime Number Check
            Write an expression that checks if given positive integer number n (n = 100) is prime (i.e. it is divisible without remainder only to itself and 1).
         */
        Console.WriteLine("Check if for given positive int n(n <= 100) is prime\n");
        Console.Write("Insert n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int a = n % 2;
        int b = n % 3;
        int c = n % 5;

        bool isPrime = (((c != 0) && ((a != 0) && (b != 0))) && ((n >= 2) && ( n <= 100)));

        if (n == 2 || n  == 3 || n == 5)
        {
            isPrime = true;
        }

        Console.WriteLine("Is the integer {0} within n[0;100] prime?\n{1}!", n, isPrime);
    }
}
