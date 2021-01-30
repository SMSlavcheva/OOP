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
        
        public string foodEaten;

        protected Herbivorous(string name):base(name)
        {   
            
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
        public override string Speak()
        {
            
           return $"I'm {this.GetType().Name} {this.Name}. I have {this.Health} points live! ";
          

        }

        //като след всяко хранене животното трябва да каже какво е, какво е яло,
        //колко точки живот са му останали. Ако е умряло, пазача го прескача и дава храна на другите. 

        //След като мине 5-тото хранене, да се изпринтират животните и техните данни.
        public override string ToString()
        {
            return base.ToString() + $"I have eaten {this.foodEaten}";
        }

    }

    
}
