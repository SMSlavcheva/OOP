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
        public Predator(string name) : base(name)
        {          
        }

        public override string SayRestOfLive()
        {
            return base.SayRestOfLive();
        }

        public override string SayWhatIAm()
        {
            return base.SayWhatIAm() + GetType().Name;
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
        public override string ToString()
        {
            return base.ToString() + $"\nI have eaten {this.foodEaten}.\nI have {this.Health} resting live points";
        }
    }
}
