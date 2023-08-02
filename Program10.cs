using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace App5
{

    // Grouping

    class Employee
    {
        public string name;
        public string gender;
    }
    internal class Program10
    {
        static void Main(string[] args)
        {
            Employee[] employee ={
                        new Employee{name = "matt", gender="male"},
                        new Employee{name = "chris", gender="male"},
                        new Employee{name = "natasha", gender="female"},
                        new Employee{name = "matt", gender="male"},
                        new Employee{name = "paula", gender="female"}
            };

            var empGroup = from emp in employee group emp by emp.gender;

            foreach(var grp in empGroup)
            {
                Console.WriteLine("Group -> " + grp.Key);       //key is the group name

                foreach (var e in grp)
                {
                    Console.WriteLine(e.name + " " + e.gender);     //in a group, 
                }
                Console.WriteLine("=============================");
            }
            
        }
    }
}
