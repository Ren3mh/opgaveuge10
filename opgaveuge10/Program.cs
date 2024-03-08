using System.Globalization;

namespace opgaveuge10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Opgave 1.4

            int[] AskForAges()
            {
                int persons = AmoutOfPersones();
                int[] ages = new int[persons];

                for (int person = 0; person < persons; person++)
                {
                    while (true)
                    {
                        Console.WriteLine($"Skriv {person+1}. persons alder: ");
                        try
                        {
                            ages[person] = int.Parse(Console.ReadLine());
                            break;
                        }
                        catch (FormatException)
                        { Console.WriteLine("Du skal skrive et heltal."); }
                    }
                }

                return ages;

                int AmoutOfPersones()
                {

                    int antalpers;

                    while (true)
                    {
                        Console.Write("Hvor mange personer er i? ");

                        try
                        {
                            antalpers = int.Parse(Console.ReadLine());

                            if (antalpers > 0)
                                return antalpers;

                            else
                                Console.WriteLine("Du må ikke skrive 0");

                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Skriv et tal!");
                        }
                    }
                }
            }

            foreach (int persAge in AskForAges()) { Console.WriteLine(persAge); }

            Console.ReadLine();


        }
    }
}
