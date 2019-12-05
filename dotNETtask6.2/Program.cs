using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNETtask6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimeNumbers primes = new PrimeNumbers();
            Console.WriteLine("Введите n");
            int n = int.Parse(Console.ReadLine() ?? "100");
            foreach (int primeNumber in primes)
            {
                n--;
                Console.Write(primeNumber+"  ");
                if (n == 0) break;
            }

            Console.ReadLine();
        }

    }
}
