using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;
using Zoo.Models.Food;

namespace Zoo.Models
{
   public abstract class Predator:Animal
    {
        private string foodEaten;
        protected Predator(string name) : base(name)
        {          
        }
              
        public override void Eat(IFood food)

        {
            var foodType = food.Name;

            if (Enum.IsDefined(typeof(Not_Meat_Enum), foodType))
            {
                this.Health = this.Health-1;
            }

            if (foodType == "poison")
            {
                this.Health = 0;
            }

            else
            {
                this.foodEaten = foodType;
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
