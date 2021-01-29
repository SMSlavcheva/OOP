using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;
using Zoo.Models.Food;

namespace Zoo.Models
{
    public abstract class Animal:IAnimal,ISpeakable
    {
        private const int Livespan=5;
        private string name;
        private int health;
        private IFood food;

        //Ако умрат, не могат да говорят
        public Animal(string name)
        {
            this.Name = name;
            this.Health = Livespan;
        }

        public int Health { get; set; }
        public string Name 
        {
            get 
            {
                return this.Name;
            }
            set 
            {

                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(ExceptionMessages.InvalidNameException);
                }
            }        
        }

       
        public virtual void Eat(IFood food)
        {
            throw new NotImplementedException();
        }

        public virtual string SayRestOfLive()
        {
            if (this.Health==0)
            {
                return null;
            }
            return $"Rest of live: ";
        }

        public virtual string SayWhatIAm()
        {
            if (this.Health == 0)
            {
                return null;
            }
            return $"I'm ";
        }

        public override string ToString()
        {
            return $"I'm {this.GetType().Name}";
        }


    }
}
