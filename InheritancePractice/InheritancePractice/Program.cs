﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Banana banana = new Banana();
            Console.WriteLine(banana.Sweetness);
            banana.WhatAmI();
        }
    }
}
