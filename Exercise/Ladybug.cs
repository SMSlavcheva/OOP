using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public class Ladybug : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("I can' fly with wet wings");
        }
    }
}