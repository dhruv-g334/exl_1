using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App5
{
    class User
    {
        public int id;
        public string name;
        public string city;
        public string dateofbirth;
    }
    internal class Program7
    {
        static void Main(string[] args)
        {
            //using linq in object

            User[] users = {new User {id = 1,name = "paul",city = "dallas",dateofbirth = "25-2-2002" },
                            new User {id = 2,name = "luke",city = "nevada",dateofbirth = "24-3-2002" },
                            new User {id = 3,name = "nick",city = "austin",dateofbirth = "23-2-1998" },
                            new User {id = 4,name = "rahul",city = "fort wayne",dateofbirth = "25-7-1992" },
                            new User { id = 5, name = "steve", city = "toronto", dateofbirth = "5-4-2008" }, 
                            new User { id = 6, name = "rob", city = "hongkong", dateofbirth = "25-2-2002" },
                            new User { id = 7, name = "newman", city = "dallas", dateofbirth = "2-10-2003" }, 
                            new User { id = 8, name = "alex", city = "hongkong", dateofbirth = "8-7-2002" },
                            new User { id = 9, name = "natalie", city = "lansing", dateofbirth = "5-12-2012" }, 
                            new User { id = 10, name = "jacob", city = "washington", dateofbirth = "25-9-2006" }, 
                            new User { id = 11, name = "larry", city = "hongkong", dateofbirth = "9-2-2004" }};

            var result = from usr in users where usr.city == "hongkong" select usr;
            
            foreach(var user in result)
            {
                Console.WriteLine(user.name + " "+user.city);
            }
            
        }
    }
}
