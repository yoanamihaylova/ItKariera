﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Creature p = new Creature();
            p.SetName("Creature"); 
            Console.WriteLine(p.GetName());
        }
    }
}
