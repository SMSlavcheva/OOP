using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public class Eagle:Bird,IFlyable
    {
        public override void Eat()
        {
            Console.WriteLine("I will start to eat meat");
        }

        public void Fly()
        {
            Console.WriteLine("I will fly away");
        }
    }
}
