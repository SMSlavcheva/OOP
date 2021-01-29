using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zoo.Interfaces;
using Zoo.Models.Food;

namespace Zoo.Models
{
    public abstract class Herbivorous :Animal
    {
        //public Not_Meat_Enum allowedFood { get; set; }
        public string foodEaten;

        public Herbivorous(string name):base(name)
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
                this.Health = this.Health;
                
            }

            else if (foodType == "poison")
            {
                this.Health = 0;
            }

            else
            {
                this.Health = this.Health - 1;
            }

            this.foodEaten = foodType;

        }

       
        //като след всяко хранене животното трябва да каже какво е, какво е яло,
        //колко точки живот са му останали. Ако е умряло, пазача го прескача и дава храна на другите. 

        //След като мине 5-тото хранене, да се изпринтират животните и техните данни.
        public override string ToString()
        {
            return base.ToString() + $"\nI have eaten {this.foodEaten}\nI have {this.Health} points live.";
        }


    }

    
}
