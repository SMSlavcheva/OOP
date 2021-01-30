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
               
        protected Animal(string name)
        {
            this.Name = name;
            this.Health = Livespan;
        }

        public int Health { get; set; }
        public string Name { get; set; }
       // {
            //get 
            //{
            //    return this.Name;
            //}
            //set 
            //{

            //    if (string.IsNullOrEmpty(value))
            //    {
            //        throw new ArgumentNullException(ExceptionMessages.InvalidNameException);
            //    }

            //    this.name = value;
            //}        
       // }

       
        public virtual void Eat(IFood food)
        {
            throw new NotImplementedException();
        }
              

        public virtual string Speak()
        {
                      
          return $"I'm {this.GetType().Name} {this.Name}. I have {this.Health} points live! ";   
                 

            
        }

        public override string ToString()
        {
            return $"{this.Speak()}";
        }



    }
}
