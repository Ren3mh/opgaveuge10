﻿namespace opgaveuge10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Opgave 1.1
            //Console.WriteLine("Hello, World!");
            //int Sami = 27;
            //int Peter = 26;
            //int Robin = 24;
            //int Sander = 24;
            //int René = 34;
            //int Ronald = 44;

            //Console.WriteLine(Sami);
            //Console.WriteLine(Peter);
            //Console.WriteLine(Robin);
            //Console.WriteLine(Sander);
            //Console.WriteLine(René);
            //Console.WriteLine(Ronald);



            //double gennemsnit = (double)(Sami + Peter + Robin + Sander + René + Ronald ) / 6;

            //Console.WriteLine("Gennemsnitter er: " + gennemsnit);

            /*
            //Opgave 1.2
            int Sami = 27;
            int Peter = 26;
            int Robin = 24;
            int Sander = 24;
            int René = 34;
            int Ronald = 44;
            int[] ages = {Sami, Peter, Robin, Sander, René, Ronald, 34, 45, 5, 66, 100};

            double gennemsnit;
            int ageSum = 0;

            foreach ( int age in ages ) 
            {
            Console.WriteLine(age);
            }

            foreach (int age in ages)
            {
                ageSum += age;
                
            }
            Console.WriteLine("Summen er: " + ageSum);

            
            Console.WriteLine("Gennemsnittet er: " + (double) ageSum / ages.Length);



            //Opgave 1.3
            int ageseeking = 27;
            string message = "Ingen med denne alder :-(";

            foreach (int age in ages)
            {
                if (age == ageseeking)
                {
                    message = "Der er en med denne alder :-D";
                    break;
                }
            }
            Console.WriteLine(message);
            */

            //Opgave 1.4
            Console.WriteLine("Hvor mange personer er i: ");
            int antalpers = 0;

            do
            {
                try
                {
                    antalpers = int.Parse(Console.ReadLine());
                    if ( antalpers != 0 )
                    {
                        break;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Skriv et tal!");
                    Console.WriteLine(ex);
                }
            } while (true);

                Console.WriteLine("Antal personer: " + antalpers);

            Console.ReadLine();


        }
    }
}
