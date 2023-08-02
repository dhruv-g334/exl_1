using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App5
{
    internal class Program9
    {
        static void Main(string[] args)
        {
            //operations on list

            var numbers = new List<int> { 1,2,3,-4,5,6,7,-8,9};

            //count numbers function
            int length = numbers.Count;
            Console.WriteLine($"Total numbers are {length}");

            int length2 = numbers.Count(x => x % 2 == 0);
            Console.WriteLine($"Even numbers length {length2}");

            //sum number function
            int total = numbers.Sum();
            Console.WriteLine($"Sum {total}");

            int total2 = numbers.Sum(x => x%2 == 0 ? x:0);    //returns either even or zero
            Console.WriteLine($"Even numbers sum {total2}");

            double mean = Math.Round(numbers.Average(),2);
            Console.WriteLine($"Average is {mean}");

            int minval = numbers.Min();
            Console.WriteLine($"Min is {minval}");

            int maxval = numbers.Max();
            Console.WriteLine($"Max is {maxval}");

            var result = from num in numbers orderby num ascending select num;

            Console.WriteLine(string.Join(", ",result));

        }
    }
}
