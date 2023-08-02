using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App5
{
    internal class Program4
    {
        static void Main(string[] args)
        {
            int[] wtp = { 228, 190, 120, 150, 160, 165 };

            var wtkg = wtp.Select(x => 0.4535*x);
            Console.WriteLine(string.Join(", ", wtkg));
        }
    }
}
