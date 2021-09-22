using System;


namespace HumanApp
{
   public class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human("Armen", "Avagyan", 45);
            human.Print("BMW");
            Student student = new Student("Ani", "Avyan", 19) ;
            student.Learn("SEUA");
            Doctor doctor = new Doctor("Narek", "Kareyan",25);
            doctor.Heal();
            Singer singer = new Singer("Sharl","Aznavur",89);
            singer.Sing("'She'");
            Console.ReadLine();
        }
    }
}
