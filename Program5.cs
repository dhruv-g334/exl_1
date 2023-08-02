using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App5
{
    internal class Program5
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //select function is like map() function in python
            var result1 = nums.Select(x => x * x);
            Console.WriteLine(string.Join("-", result1));
        }
    }
}
