using System.Globalization;

namespace opgaveuge10
{
    internal class MenuSystem
    {
        static void Main(string[] args)
        {

            //Opgave 3.5

            Menu menu = new Menu(title: "Min Fantastiske Menu");
            
            string[,] menuItems = { { "Gør dit", "Gør dit" }, { "Gør dat", "Gør dat" }, { "Gør noget", "Gør noget" }, { "Få svaret på livet", "42" } };
            

            for (int i = 0; i < menuItems.GetLength(0); i++)
                menu.AddMenuItem(menuItems[i, 0], menuItems[i, 1]);

            menu.Show();

            menu.SelectMenuItem();

            Console.ReadLine();


        }
    }
}
