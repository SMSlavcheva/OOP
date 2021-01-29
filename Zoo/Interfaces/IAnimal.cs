using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Models.Food;

namespace Zoo.Interfaces
{
    public interface IAnimal
    {
        string Name { get; set; }

        int Health { get; set; }
        public void Eat(IFood food);


        //void Eat();
        //string Speak();
    }
}
