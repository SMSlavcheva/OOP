using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public class Sparrow : Bird, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("I will stay here..");
        }
    }
}
