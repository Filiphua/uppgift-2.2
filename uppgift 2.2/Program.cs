using System;


namespace uppgift_2._2
{
      class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många meter hoppade Alma och Elin?");
            int Almahopp = int.Parse(Console.ReadLine());
            int Elinhopp= int.Parse(Console.ReadLine());
            Console.WriteLine(Elinhopp - Almahopp);


        }
    }
}
