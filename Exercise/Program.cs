using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {

            //Person driver = new Person("Ivan", "Ivanov", "Ivanov");
            //var car = new Car("suzuki", Color.Red, 150, driver);

            //var birds = new List<Bird>();
            //var birds1 = new List<IFlyable>();

            //var sparrow = new Sparrow();
            //var swallow = new Swallow();
            //var eagle = new Eagle();
            //var ostrage = new Ostrage();

            //birds.Add(sparrow);
            //birds.Add(swallow);
            //birds.Add(eagle);
            //birds.Add(ostrage);

            //foreach (var bird in birds)
            //{
            //    Console.WriteLine($"{bird.GetType().Name}");
            //    bird.Eat();               

            //}


            //IFlyable sparrow1 = new Sparrow();
            //IFlyable swallow2 = new Swallow();
            //IFlyable eagle3 = new Eagle();


            //birds1.Add(sparrow1);
            //birds1.Add(swallow2);
            //birds1.Add(eagle3);

            ////Exercise Car
            //Car car1 = new Car("suzuki", Color.Red, 80);
            //Car car2 = new Car("suzuki", Color.Red, 150);
            //Car car3 = new Car("Opel", Color.Blue, 75);

            //Console.WriteLine(car1.CompareTo(car2));
            //Console.WriteLine(car1.CompareTo(car3));


            //var carList = new List<Car>();

            //carList.Add(car1);
            //carList.Add(car2);
            //carList.Add(car3);

            //var orderedList = carList.OrderBy(c => c.HorsePower).ToList();
            //foreach (var item in orderedList)
            //{
            //    Console.WriteLine($"{item.Brand}-{item.Colour}-{item.HorsePower}");

            //}

            Student student1 = new Student("Ivan", "Ivanov", "Ivanov");
            Student student2 = new Student("Anna", "Ivanova", "Ivanova");
            var theacher = new Teacher("Nikolai", "Nikolov", "Nikolov");

            student2.Study("C Sharp");

            theacher.Exam(student1);
            theacher.Exam(student2);


        }
    }
}
