using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;
using Zoo.Models.Food;

namespace Zoo.Models
{
    public abstract class Omnivorous:Animal
    {
        public string foodEaten;
        protected Omnivorous(string name):base(name)
        {                
        }             
        public override void Eat(IFood food)

        {
            var foodType = food.Name;
            this.foodEaten = foodType;

            if (Enum.IsDefined(typeof(Meat_Enum), foodType)|| Enum.IsDefined(typeof(Not_Meat_Enum), foodType))
            {
                this.Health =Health;
                
            }

            if (foodType == "poison")
            {
                this.Health = 0;
            }
        }

        public override string Speak()
        {
          
          return $"I'm {this.GetType().Name} {this.Name}. I have {this.Health} points live! ";
            

        }
        public override string ToString()
        {
            return base.ToString() + $"I have eaten {this.foodEaten}.";
        }
    }

   
}
