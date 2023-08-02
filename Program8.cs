using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App5
{
    internal class Program8
    {
        static void Main(string[] args)
        {
            // To extract hashtags

            string wish = "One #Day I'll make the #Onions #CRY";

            String[] words = wish.Split(" ");

            var result = words.Where(w => w.StartsWith('#'));

            foreach (var word in result)
            {
                Console.WriteLine(word);
            }
            

        }
    }
}
