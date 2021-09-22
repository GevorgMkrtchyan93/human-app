using System;


namespace HumanApp
{
    public class Student : Human
    {
        public Student(string _firstName, string _lastName, int _age) : base(_firstName, _lastName, _age)
        {

        }
        public void Learn(string university)
        {

            Console.WriteLine($"I am {_firstName} {_lastName},{_age} years old and I learning in {university}");
        }

    }
}
