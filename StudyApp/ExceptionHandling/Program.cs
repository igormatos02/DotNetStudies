namespace ExceptionHandling{
  class Program
    {
        static void Main(string[] args)
        {
            Operations operations = new Operations();

            // Example usage of the Divide method
            int dividend = 10;
            int divisor = 0;

            try
            {
                decimal result = operations.Divide(dividend, divisor);
                Console.WriteLine($"Result of division: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                // You may choose to log the exception or take other appropriate actions here
            }
        }
    }
}
