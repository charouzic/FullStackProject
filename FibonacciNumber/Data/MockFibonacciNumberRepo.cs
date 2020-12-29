using System.Collections.Generic;

namespace FibonacciNumber.Data
{
    public class MockFibonacciNumberRepo : IFibonacciNumberRepo
    {
        public long CalculateFibonacciNumber(int sequence)
        {
            if (sequence == 1) return 0;
            if (sequence == 2 || sequence == 3) return 1;

            long previous = 0;
            long current = 1;

            int i = 0;
            long fibNum = 0;

            while(i < sequence-2)
            {
                fibNum = previous + current;

                previous = current;
                current = fibNum;
                i++;
            }
            return fibNum;
        }
    }
}