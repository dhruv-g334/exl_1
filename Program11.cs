using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App5
{
    internal class Program11
    {
        static void Main(string[] args)
        {
            string[] file = File.ReadAllLines("D://youtube.csv");

            int records = file.Length - 1;

            //Console.WriteLine(file[1]);

            Console.WriteLine($"Total number of records are {records}.");
            
            string[] chan = new string[file.Length];
            string[] chan1 = new string[file.Length];

            for (int i = 1; i <= records; i++)
            {
                chan = file[i].Split(",");
                Array.Reverse(chan);
                chan1[i] = chan[1]; 
            }
            var uniq = chan1.Distinct();

            Console.WriteLine($"Unique Channels: {uniq.Count()}");

            /*Console.WriteLine($"Unique Channels are mentioned below: ");

            foreach (var x in uniq)
            {
                Console.WriteLine(x);
            }*/
            
            //T-Series problem

            var tser = (file.Where(element => element.Contains("T-Series"))).ToArray();      //ienumerable was directly not indexed. so converted
            
            int[] views = new int[tser.Count()];

            for (int i = 0; i < tser.Count(); i++)
            {                    
                chan = tser[i].Split(",");

                if (Convert.ToInt32(chan[2].Split("-")[0]) == 2017)
                {
                    Array.Reverse(chan);
                    views[i] = Convert.ToInt32(chan[0]);
                }
                
            }

            double maxv = views.Max();

            Console.WriteLine();
            Console.WriteLine($"Maxmimum views on a T-series video is {maxv}.");

            Console.WriteLine();


            //views per month

            int[] vpm = new int[12];

            for (int j = 0; j < 12; j++)
            {
                int k = 0;
                for (int i = 0; i < tser.Count(); i++)
                {
                    chan = tser[i].Split(",");

                    if (Convert.ToInt32(chan[2].Split("-")[1]) == j)
                    {
                        Array.Reverse(chan);
                        k = k + Convert.ToInt32(chan[0]);
                    }

                }
                vpm[j] = k;
            }

            int maxmonth = 1;

            for (int i=0; i < vpm.Length; i++)
            {
                if (vpm[i] == vpm.Max())
                {
                    maxmonth = i;
                }
            }

            Console.WriteLine($"The maximum views were in the month {maxmonth + 1} with {vpm[maxmonth]} views.");

        }
    }
}
