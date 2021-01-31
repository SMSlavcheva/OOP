using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public class Teacher : Person
    {
        public string Subject { get; set; }
        public Teacher(string firstName, string middleName, string lastName) : base(firstName, middleName, lastName)
        {
        }

        public void Exam(Student student)
        {
            student.TellMeYourLesson();
        
        }


    }
}
