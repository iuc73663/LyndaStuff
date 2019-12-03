using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> customers = new List<string>();
            customers.Add("John");
            customers.Add("Tim");
            customers.Add("Jason");

            Console.WriteLine(customers.Count);
            //loop through items 
            foreach(var customer in customers)
            {
                Console.WriteLine(customer);
            }
            //Specific index 
            Console.WriteLine(customers[1]);
        }
    }
}
