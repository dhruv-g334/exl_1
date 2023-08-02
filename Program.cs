namespace App5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // sample LINQ example
            // var is a keyword in c# that automatically determines the
            // datatype of object. can be used for all objects

            // LINQ syntax

            var words = new string[] { "flower", "elephant", "sugar", "tree", "waffer" };

            //var result = from element in words where element.Contains("a") select element;
            //var result = from element in words select element.Contains("a");

            var result = words.Where(element => element.Contains("a"));   //lambda function

            //lets us print all elements using foreach loop
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        }
    }
}