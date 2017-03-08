using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    class Banana : Fruit
    {
        public Banana() : base("yellow", "medium", 100, "meh")
        {
               
        }

        public void WhatAmI()
        {
            Console.WriteLine("I'm a banana");
        }
    }
}
