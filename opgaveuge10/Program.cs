using System.Globalization;

namespace opgaveuge10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Opgave 1.4.2

            int[] AskForAges()
            {

                int persons = AmoutOfPersones();
                int[] ages = new int[persons];

                for (int person = 0; person < persons; person++)
                {
                    while (true)
                    {
                        Console.Write($"Skriv {person+1}. persons alder: ");

                        int age;

                        if (int.TryParse(Console.ReadLine(), out age) && age > -1)
                        {
                            ages[person] = age;
                            break;
                        }

                        else
                            Console.WriteLine("Svar med et positivt heltal.");
                    }
                }

                return ages;

                int AmoutOfPersones()
                {
                    int xpersons;

                    while (true) 
                    {
                        Console.Write("Hvor mange personer er i? ");

                        if (int.TryParse(Console.ReadLine(), out xpersons) && xpersons >= 0)
                            return xpersons;

                        else
                            Console.WriteLine("Du skal svare med et positivt heltal");
                    }
                }
            }

            foreach (int persAge in AskForAges()) { Console.WriteLine(persAge); }

            Console.ReadLine();


        }
    }
}
