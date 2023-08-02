using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App5
{
    internal class Program3
    {
        static void Main(string[] args)
        {
            
            int[] nums = {47,85,65,32 };

            var result1 = nums.Prepend(45);
            Console.WriteLine(string.Join("-", result1));

            var result2 = result1.Append(38);

            Console.WriteLine(string.Join("-", result2));

        }
    }
}
