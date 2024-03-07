namespace opgaveuge10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            int Sami = 27;
            int Peter = 26;
            int Robin = 24;
            int Sander = 24;
            int René = 34;
            int Ronald = 44;
            int[] ages = {Sami, Peter, Robin, Sander, René, Ronald};

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


            Console.ReadLine();


        }
    }
}
