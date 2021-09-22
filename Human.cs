using System;


namespace HumanApp
{
    public class Human
    {
        public Human(string firstName, string lastName, int age)
        {
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
           
        }

        public string _firstName;
        public string _lastName;
        public int _age;
        private string _car;

        public virtual void Print(string _car)
        {
            Console.WriteLine($"My name is {_firstName} {_lastName}, I am {_age} and I have {_car}");
        }
    }
}
