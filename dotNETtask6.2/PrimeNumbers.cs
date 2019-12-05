using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNETtask6._2
{
    public class PrimeNumbers : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            var memoized = new List<int>();
            int sqrt = 1;
            var primes = PotentialPrimes().Where(x =>
            {
                sqrt = GetSqrtCeiling(x, sqrt);
                return !memoized
                    .TakeWhile(y => y <= sqrt)
                    .Any(y => x % y == 0);
            });
            yield return 1;
            foreach (int prime in primes)
            {
                yield return prime;
                memoized.Add(prime);
            }
        }
        private int GetSqrtCeiling(int value, int start)
        {
            while (start * start < value)
            {
                start++;
            }
            return start;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        private static IEnumerable<int> PotentialPrimes()
        {
            yield return 2;
            yield return 3;
            int k = 1;
            loop:
            yield return k * 6 - 1;
            yield return k * 6 + 1;
            k++;
            goto loop;
        }
    }
}
