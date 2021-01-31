using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public class Student : Person
    {
        public string Subject { get; set; }
        public Student(string firstName, string middleName, string lastName)
            : base(firstName, middleName, lastName)
        {
        }

        public void Study(string subject)
        {
            this.Subject = subject;
        }

        public void TellMeYourLesson() 
        {
            if (string.IsNullOrWhiteSpace(this.Subject))
            {
                Console.WriteLine($"{this.ToString()} and my dog ate my homework");
            }
            else
            {
                Console.WriteLine($"{this.ToString()} have studied {this.Subject}");
            }

        }
        public override string ToString()
        {
            return $"{this.FirstName}";
        }
    }
}
