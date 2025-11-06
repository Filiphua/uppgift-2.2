using System;


namespace uppgift_2._2
{
      class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många meter hoppade Elin än Alma?");
            int Almahopp = int.Parse(Console.ReadLine());
            int Elinhopp= int.Parse(Console.ReadLine());
            Console.WriteLine("Alma hoppade " + Almahopp + " meter ");
            Console.WriteLine("Elin hoppade " + Elinhopp + " meter. ");
            int skillnad= (Elinhopp - Almahopp);
            Console.WriteLine("Elin hoppade " + skillnad + " meter längre än Alma.");

        }
    }
}
