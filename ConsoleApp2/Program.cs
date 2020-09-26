using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int nummer = r.Next(0, 100);

            bool win = false;

            do
            {
                Console.WriteLine("Vælg et nummer mellem 1 og 100");
                int i = Convert.ToInt32(Console.ReadLine());
                if (i > nummer)
                {
                    Console.WriteLine("For højt! gæt lavere");
                }
                else if (i < nummer)
                {
                    Console.WriteLine("For lavt!! gæt højere");

                }
                else if (i == nummer)
                {
                    Console.WriteLine("DU GÆTTEDE RIGTIG");
                    win = true;
                }


                } while (win == false);
            Console.WriteLine("Tak fordi du spillede med!");
            Console.ReadKey();
                
              
            
        }
    }
}
