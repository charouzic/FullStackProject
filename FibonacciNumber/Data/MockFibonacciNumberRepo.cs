using System.Collections.Generic;
using System.Linq;
using FibonacciNumber.Models;

namespace FibonacciNumber.Data
{
    public class MockFibonacciNumberRepo : IFibonacciNumberRepo
    {
        List<FibonacciNumberObj> fibonaccis = new List<FibonacciNumberObj>
        {
            
            new FibonacciNumberObj{Id=0, Sequence = 0, Value = 0},
            new FibonacciNumberObj{Id=1, Sequence = 1, Value = 1},
            new FibonacciNumberObj{Id=2, Sequence = 2, Value = 1},
            new FibonacciNumberObj{Id=3, Sequence = 3, Value = 2},
            new FibonacciNumberObj{Id=4, Sequence = 4, Value = 3},
            new FibonacciNumberObj{Id=5, Sequence = 5, Value = 5},
            new FibonacciNumberObj{Id=6, Sequence = 6, Value = 8},
            new FibonacciNumberObj{Id=7, Sequence = 7, Value = 13},
            new FibonacciNumberObj{Id=8, Sequence = 8, Value = 21},
            new FibonacciNumberObj{Id=9, Sequence = 9, Value = 34},
            new FibonacciNumberObj{Id=10, Sequence = 10, Value = 55}
        };
        public long CalculateFibonacciNumber(int sequence)
        {
            if (sequence == 0) 
            {
                return 0;
            }
            
            else  if (sequence == 1)
            {
                return 1;
            }
             
            else
            {
                long fibNum = 0;
                long previous = 1;
                long current = 1;
                for (int l = 2; l <= sequence; l++)
                {
                    fibNum = previous + current;

                    previous = current;
                    current = fibNum;
                }
                return fibNum;
            }
        }

        public void CreateFibonacciRecord(int sequence, int value)
        {
            int id = sequence-1;

            fibonaccis.Add(new FibonacciNumberObj{Id = id, Sequence = sequence, Value = value});  
        }

        public IEnumerable<FibonacciNumberObj> GetAppFibonaccis()
        {
            return fibonaccis;
        }

        public FibonacciNumberObj GetFibNumBySeq(int seq)
        {

            foreach(FibonacciNumberObj i in fibonaccis)
            {
                if(i.Sequence == seq)
                    return i;
            }

            return null;
        }

        public bool CheckRecordForSave(int sequence, int value)
        {
            bool status = true;
            var fibonaccis = GetAppFibonaccis();
            // 1. check if the record is not already there
            foreach(FibonacciNumberObj element in fibonaccis)
            {
                if (sequence == element.Sequence)
                    status = false;
            }
            // 2. check if the value is correct
            if (value != CalculateFibonacciNumber(sequence))
                status = false;

            return status;
        }

        public void DeleteFibonacciRecord(int seq)
        {
            fibonaccis.Remove(fibonaccis.Single(x => x.Sequence == seq));
        }
    }
}