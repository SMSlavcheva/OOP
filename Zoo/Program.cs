using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Zoo.BusinessLogic;
using Zoo.Interfaces;
using Zoo.Models;
using Zoo.Models.Animals;
using Zoo.Models.Food;

namespace Zoo
{
    public class Program
    {
       public static void Main(string[] args)
       {            



        Engine engine = new Engine();
            engine.FeedAnimals();
            Console.WriteLine();
            Console.WriteLine();
          //  engine.PrintAliveanimals();
        
            
            

       }
    }
}
