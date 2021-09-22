using System;


namespace HumanApp
{
    class Doctor:Human
    {
        public Doctor(string _firstName, string _lastName, int _age):base(_firstName, _lastName, _age)
        {

        }

        public void Heal()
        {
            Console.WriteLine($"{_firstName} {_lastName} is sick and I heal heam");
        }
    }
}
