﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Collections
{
    class Auto
    {
        public string Name { get; set; }
        public int MaxSpeed { get; set; }
        public int Price;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var autos = new List<Auto>();
            autos.Add(new Auto { Name = "SUV", MaxSpeed = 101, Price = 2000 });
            autos.Add(new Auto { Name = "Sedan", MaxSpeed = 120, Price = 1000 });
            autos.Add(new Auto { Name = "Coupe", MaxSpeed = 110, Price = 3000 });

            // TBD: Fix the lowest price auto
            
            var auto = autos.

                /*
                 * questions                 
                 Why didn't my execution of code work? Execution per line item of a results query?  
                 
             
             */
//            Console.WriteLine("Lowest Price: Name={0} Price={1}", auto.Name, auto.Price);

            // TBD: Fix the fastest auto
            //Console.WriteLine("Fastest Speed: Name={0} Speed={1}", auto.Name, auto.MaxSpeed);

            Console.ReadLine();
        }
    }
}