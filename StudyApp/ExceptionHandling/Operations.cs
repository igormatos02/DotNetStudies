using System;

namespace ExceptionHandling
{
    public class Operations
    {
        public decimal Divide(int a, int b)
        {
            try
            {
                if (b == 0)
                {
                    throw new DivideByZeroException($"Cannot divide {a} by zero.");
                }
                
                decimal result = (decimal)a / b;
                return result;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Log: " + ex.Message);
                throw;
            }
        }
    }
}