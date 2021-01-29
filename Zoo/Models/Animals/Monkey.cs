using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Models.Animals
{
    public class Monkey:Omnivorous
    {
        public Monkey(string name) : base(name) { }
    }
}
