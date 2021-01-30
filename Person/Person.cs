using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Person
    {
        public static int peopleNumber;

        public Person(string firstName, string middleName, string lastName)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = LastName;

            peopleNumber++;

        }
        public string FirstName{ get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return $"My name is {this.FirstName}, {this.MiddleName}, {this.LastName}​";
        }
    }
}
