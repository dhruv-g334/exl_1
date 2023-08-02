using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App5
{
    internal class Program6
    {
        static void Main(string[] args)
        {
            int[] sal = { 34000, 24000, 31000, 28000, 29000, 33000 };

            var nsal = sal.Select(x => 1.03 * x);
            Console.WriteLine(string.Join(", ", nsal));
        }
    }
}
