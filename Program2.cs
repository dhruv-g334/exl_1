using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App5
{
    internal class Program2
    {
        static void Main(string[] args)
        {

            var words = new string[] { "flower", "elephant", "sugar", "tree", "waffer" };

            Console.WriteLine(words.ElementAt(1));
            //element at index 1, indexing starts from 0
            Console.WriteLine(words.First());
            Console.WriteLine(words.Last());

            Console.WriteLine(words.First(element => element.Length == 6));   
            //first word with 6 letters
            Console.WriteLine(words.Last(element => element.Length == 6));
            //first word from last with 6 letters

        }
    }
}
