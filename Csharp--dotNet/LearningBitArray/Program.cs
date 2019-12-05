using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] preload = new bool[3] {false,true,false};
            BitArray enemyGrid = new BitArray(preload);

            /*
            enemyGrid[0] = false;
            enemyGrid[1] = true;
            enemyGrid.Set(2, false);
            */
            foreach(var i in enemyGrid)
            {
                Console.WriteLine(i);
            }
        }
    }
}
