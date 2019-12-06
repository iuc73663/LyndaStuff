using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> pancakes = new Stack<string>();
            pancakes.Push("First");
            pancakes.Push("Second");
            pancakes.Push("Third");
            pancakes.Push("Fourth");
            pancakes.Push("Fifth");

            /*
            foreach(var pancake in pancakes)
            {
                Console.WriteLine(pancake);
            }
            */
            for (int i = pancakes.Count(); i > 0; i--)
            {
                Console.WriteLine(pancakes.Peek());
                pancakes.Pop();
            }
        }
    }
}
