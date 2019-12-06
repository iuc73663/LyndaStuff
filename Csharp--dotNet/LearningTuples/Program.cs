using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningTuples
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] age = new int[3] { 1,2,3};
            String[] names = new String[3] { "Bob","Chris","meg"};
            bool[] isMale = new bool[3] { true,true,false};

            ArrayList myTuples = new ArrayList();
            
            for(int i = 0; i < 3;i++)
            {
                myTuples.Add(Tuple.Create(age[i],names[i],isMale[i]));
            }

            foreach(var a in myTuples)
            {
                Console.WriteLine(a.ToString());
            }

        }
    }
}
