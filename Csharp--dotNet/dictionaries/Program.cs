﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, String> config = new Dictionary<string, string>();
            config.Add("resolution", "1920*800");
            config.Add("title", "Example Test");
            config.Add("user", "user01");

            foreach(var setting in config)
            {
                Console.WriteLine(setting.Value);
            }


        }
    }
}
