﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTopics
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstClass myFirstClass = new FirstClass(56);

            Console.WriteLine(myFirstClass.Number);
        }
    }
}