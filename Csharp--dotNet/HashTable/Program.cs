﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable table = new Hashtable();
            table.Add("title", "My Website");

            var s = (String)table["title"];
            Console.WriteLine(s);

        }
    }
}
