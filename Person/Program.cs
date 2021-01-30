using System;

namespace Person
{
   public class Program
    {
        public static void Main(string[] args)
        {
            var person = new Person("zz", "aaa", "eeee");
            var person1 = new Person("zz", "aaa", "eeee");
            
            Console.WriteLine(Person.peopleNumber);
        }
    }
}
