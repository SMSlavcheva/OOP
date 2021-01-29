using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Models.Food
{
    public abstract class Food :IFood
    {

        public string Name { get; set; }

        public Food(string name)
        {
            this.Name = name;
        }
        //public Meat_Enum meat { get; }
        //public Not_Meat_Enum notMeat { get; }
        //public int Poison { get; }
    }
}