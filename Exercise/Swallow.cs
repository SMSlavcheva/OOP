using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public class Swallow : Bird, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("I will fly away");
        }
    }
}
