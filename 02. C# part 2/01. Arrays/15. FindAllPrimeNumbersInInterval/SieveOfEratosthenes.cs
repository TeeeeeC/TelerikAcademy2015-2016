using System;
using System.Numerics;
using System.Collections.Generic;

class SieveOfEratosthenes
{
    static void Main()
    {
        /*
         Problem 15. Prime numbers
            Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.
         */
        int n = 1000000;
        int[] arr = new int[n];
        BigInteger i = new BigInteger();
        BigInteger j = new BigInteger();

        i = 2; 
        j = 0;

        List<int> primes = new List<int>();

        while (i < n)
        {
            if (arr[(int)i] == 0)
            {
                primes.Add((int)i);
                j = i * i;

                while (j < n)
                {
                    arr[(int)j] = 1;
                    j += i;
                }
            }
            i++;
        }
    }
}
