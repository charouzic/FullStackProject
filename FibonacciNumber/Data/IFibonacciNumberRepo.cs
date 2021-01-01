using System.Collections.Generic;
using FibonacciNumber.Models;

namespace FibonacciNumber.Data
{
    public interface IFibonacciNumberRepo
    {
        // creating interface for returning the Fibonacci number based on user's input
        long CalculateFibonacciNumber(int sequence);

        FibonacciNumberObj GetFibNumBySeq(int seq);
        IEnumerable<FibonacciNumberObj> GetAppFibonaccis();
        void CreateFibonacciRecord(int sequence, int value);
        bool CheckRecordForSave(int sequence, int value);
        void DeleteFibonacciRecord(int seq);
    }
}