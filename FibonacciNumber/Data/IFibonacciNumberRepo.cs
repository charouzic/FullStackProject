namespace FibonacciNumber.Data
{
    public interface IFibonacciNumberRepo
    {
        // creating interface for returning the Fibonacci number based on user's input
        long CalculateFibonacciNumber(int sequence);
    }
}