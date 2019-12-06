using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<String> customers = new Queue<string>();

            customers.Enqueue("Bob");
            customers.Enqueue("Joe");
            customers.Enqueue("Kevin");
            customers.Enqueue("Donald");
            customers.Enqueue("Mike");

            /*
            foreach(var customer in customers)
            {
                Console.WriteLine(customer);
            }
            */

            for(int i = customers.Count; i > 0; i--)
            {
                Console.WriteLine(customers.Peek());
                customers.Dequeue();
            }


        }
    }
}
