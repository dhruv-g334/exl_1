namespace App2read
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string csvFilePath = "d:\\google_stock_price.csv";
            
            // Read the CSV file and parse stock prices into a double array
            double[] googleStockPrices = File.ReadAllLines(csvFilePath)
                                            .Select(double.Parse)
                                            .ToArray();

            // Find the minimum and maximum values
            double min = googleStockPrices.Min();
            double max = googleStockPrices.Max();

            // Calculate the sum, average, and count
            double sum = googleStockPrices.Sum();
            double average = googleStockPrices.Average();
            int count = googleStockPrices.Length;

            // Calculate variance and standard deviation
            double variance = googleStockPrices.Select(x => Math.Pow(x - average, 2)).Sum() / count;
            double stdDeviation = Math.Sqrt(variance);

            // Output the results
            Console.WriteLine("Google Stock Prices from CSV file:");
            Console.WriteLine(string.Join(", ", googleStockPrices));
            Console.WriteLine("Minimum value: " + min);
            Console.WriteLine("Maximum value: " + max);
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average: " + average);
            Console.WriteLine("Count: " + count);
            Console.WriteLine("Variance: " + variance);
            Console.WriteLine("Standard Deviation: " + stdDeviation);
        }
    }
}