using System.Globalization;

namespace opgaveuge10
{
    internal class MenuSystem
    {
        static void Main(string[] args)
        {

            //Opgave 3.4

            Menu menu = new Menu(title: "Min Fantastiske Menu");
            
            string[] menuTitles = { "Gør dit", "Gør dat", "Gør noget", "Få svaret på livet" };

            foreach (string menuTitle in menuTitles)
                menu.AddMenuItem(menuTitle);

            menu.Show();

            int menuItem = menu.SelectMenuItem();
            Console.WriteLine("Valgt menu: " + menuItem);

            Console.ReadLine();


        }
    }
}
