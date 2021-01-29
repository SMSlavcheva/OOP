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
        public Omnivorous(string name):base(name)
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
        public override string ToString()
        {
            return base.ToString() + $"\nI have eaten {this.foodEaten}\nI have {this.Health} points live.";
        }
    }

   
}
