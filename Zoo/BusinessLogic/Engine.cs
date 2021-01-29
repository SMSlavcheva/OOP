using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Zoo.Interfaces;
using Zoo.Models.Animals;
using Zoo.Models.Food;

namespace Zoo.BusinessLogic
{
    public class Engine
    {
        private void GeTListOfAllFoods()
        {
            var foods = new List<string>();

            var meats = Enum.GetNames(typeof(Meat_Enum)).ToList();
            var notMeats = Enum.GetNames(typeof(Not_Meat_Enum)).ToList();

            foreach (var item in meats)
            {
                foods.Add(item);
            }
            foreach (var item in notMeats)
            {
                foods.Add(item);
            }
        }
        private void GeTListOfAllAnimals()
        {
            var animals = Assembly.GetExecutingAssembly().GetTypes()
                      .Where(t => t.Namespace == "Zoo.Models.Animals")
                      .ToList();
        }
        
        //TODO to generate random object list Food/Animal
        public IList<IFood> GeneratedRandomFoodList()

        {

            return null;
        
        }
        public IList<IAnimal> GeneratedRandomAnimalList()

        {

            return null;

        }
        /// <summary>
        /// 1.
        /// /monkey-chicken
        /// buffalo -tomatoe
        /// pig-salami
        /// bear- saucage
        /// 
        /// 2.buffalo-bread
        /// bear-stake
        /// 
        /// 3.
        /// </summary>

        public IList<IAnimal> animals = new List<IAnimal>
        { new Tiger("Tigyrcho"),new Monkey("Munmun"),new Lion("Lioncho"),new Buffalo("Buffi"), new Cat("Mazz"),
           new Donkey("Mryn"), new Pig("Piggy"), new Camel("Camelcho"), new Bear("Misho"), new Giraffe("Gigii")
        };

        public IList<IFood> foods = new List<IFood>()
        {
         new Poison(),new MeatFood(Meat_Enum.chicken.ToString()),new Poison(),new VeggieFood(Not_Meat_Enum.tomatoe.ToString()),new Poison(),
         new Poison(),new MeatFood(Meat_Enum.salami.ToString()),new Poison(),new MeatFood(Meat_Enum.sausage.ToString()),new Poison(),

         new Poison(),new VeggieFood(Not_Meat_Enum.bread.ToString()),new Poison(),new MeatFood(Meat_Enum.stake.ToString()),new Poison(),
         new Poison(),new VeggieFood(Not_Meat_Enum.bananas.ToString()),new Poison(),new MeatFood(Meat_Enum.sausage.ToString()),new Poison(),
         new Poison(),new VeggieFood(Not_Meat_Enum.bread.ToString()),new Poison(),new MeatFood(Meat_Enum.stake.ToString()),new Poison(),
         new VeggieFood(Not_Meat_Enum.bananas.ToString()),new Poison(),new MeatFood(Meat_Enum.sausage.ToString()),new Poison(),
         new Poison(),new MeatFood(Meat_Enum.chicken.ToString()),new Poison(),new VeggieFood(Not_Meat_Enum.tomatoe.ToString()),new Poison(),
         new Poison(),new MeatFood(Meat_Enum.salami.ToString()),new Poison(),new MeatFood(Meat_Enum.sausage.ToString()),new Poison(),
         new Poison(),new VeggieFood(Not_Meat_Enum.bread.ToString()),new Poison(),new MeatFood(Meat_Enum.stake.ToString()),new Poison(),
         new Poison(),new VeggieFood(Not_Meat_Enum.bananas.ToString()),new Poison(),new MeatFood(Meat_Enum.sausage.ToString()),new Poison(),
        };


        public void FeedAnimals()
        {
            for (int i = 0; i < 5; i++)//1
            {
                if (animals.All(a=>a.Health==0))
                {
                    break;
                }
                var count = 0;
                Console.WriteLine($" {i+1} time");
                foreach (var animal in animals)
                {
                   
                    if (animal.Health!=0)
                    { 
                        var food = foods.First();
                        animal.Eat(food);
                        count++;
                        foods.Remove(food);

                        if (animal.Health!=0)
                        {

                            Console.WriteLine(animal);
                        }
                        
                    }                
                                      
                }

                
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
               
        }

        //public void PrintAliveAnimals()
        //{
        //    var aliveAnimals = animals.Where(a => a.Health != 0);

        //    foreach (var alive in aliveAnimals)
        //    {
        //        Console.WriteLine(alive);
        //    }
        
        //}

    }
}
