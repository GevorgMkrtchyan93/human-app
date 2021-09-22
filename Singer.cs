using System;


namespace HumanApp
{
    public class Singer:Human
    {
        public Singer(string _firstName, string _lastName, int _age) : base(_firstName, _lastName, _age)
        {

        }
        public void Sing(string song)
        {
            Console.WriteLine($"I am {_firstName} {_lastName} {_age},and I will sing {song}");
        }
    }
}
