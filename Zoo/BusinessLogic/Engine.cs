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
        private List<IAnimal> animalsList;
        private List<IFood> foodsList;
        public Engine()
        {
            InitAnimals();
            InitFoods();
        }
        private List<string> GeTListOfAllFoods()
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
            foods.Add("poison");

            return foods;
        }
        private List<Type> GetListOfAllAnimals()
        {
            return Assembly.GetExecutingAssembly().GetTypes()
                      .Where(t => t.Namespace == "Zoo.Models.Animals")
                      .ToList();
        }

        //TODO to generate random object list Food/Animal
        private void InitFoods()
        {
            this.foodsList = new List<IFood>();
            var listOfAllFoods = GeTListOfAllFoods();
            var random = new Random();
            for (int i = 0; i < 50; i++)
            {
                var name = listOfAllFoods[random.Next(listOfAllFoods.Count - 1)];

                if (Enum.IsDefined(typeof(Not_Meat_Enum), name))
                {                     
                    foodsList.Add(new VeggieFood(name));
                }
                else if (Enum.IsDefined(typeof(Meat_Enum), name))
                {                
                    foodsList.Add(new MeatFood(name));
                }
                else
                {
                    foodsList.Add(new Poison());                
                }
            }   
        
        }

        private void InitAnimals()
        {
            this.animalsList = new List<IAnimal>();
            var animalTypes = GetListOfAllAnimals();
            var random = new Random();
            for (int i = 0; i < 10; i++)
            {
                var animalType = animalTypes[random.Next(animalTypes.Count() - 1)];
                var instanceType = Type.GetType(animalType.FullName);
                var animal = Activator.CreateInstance(instanceType, GetRandomName());
                animalsList.Add((IAnimal)animal);
            }
        }

        private string GetRandomName(int minLen = 3, int maxLen = 10)
        {
            var rnd = new Random();
            var len = rnd.Next(minLen, maxLen);
            var name = "";
            for (int i = 0; i < len - 1; i++){
                var c = (char)((char)'a' + rnd.Next(0, 26));
                name += i == 0 ? c.ToString().ToUpper() : c.ToString();
            }
            return name;
        }

   
                   

        public void PrintAnimalsData()
        {
            foreach (var animal in animalsList)
            {
                Console.WriteLine(animal);
            }

        }
        public void FeedAnimals()
        {
            for (int i = 0; i < 5; i++)
            {
                if (animalsList.All(a => a.Health == 0))
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"Feeding: {i + 1} ");
                    foreach (var animal in animalsList)
                    {
                        if (animal.Health != 0)
                        {
                            var food = foodsList.First();
                            animal.Eat(food);
                            foodsList.Remove(food);

                            if (animal.Health != 0)
                            {
                                Console.WriteLine(animal);
                            }
                        }

                    }
                }
            }
        }



    }
}
