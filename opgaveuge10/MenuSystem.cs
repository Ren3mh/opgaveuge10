using System.Globalization;

namespace opgaveuge10
{
    internal class MenuSystem
    {
        static void Main(string[] args)
        {

            //Opgave 3.6

            Menu menu = new Menu(title: "Min Fantastiske Menu");

            string[] menuItems = { "Gør dit", "Gør dat", "Gør noget" };

            // submenu 1
            string[] subMenuItems1 = { "Menupunkt 1.1", "Menupunkt 1.2", "Menupunkt 1.3" };
            string[] subMenuItem11 = { "Menupunkt 1.1.1", "Menupunkt 1.1.2", "Menupunkt 1.1.3" };
            string[] subMenuItem12 = { "Menupunkt 1.2.1", "Menupunkt 1.2.2", "Menupunkt 1.2.3" };

            //// submenu 2
            string[] subMenuItems2 = { "Menupunkt 2.1", "Menupunkt 2.2", "Menupunkt 2.3" };
            string[] subMenuItem21 = { "Menupunkt 2.1.1", "Menupunkt 2.1.2", "Menupunkt 2.1.3" };
            string[] subMenuItem22 = { "Menupunkt 2.2.1", "Menupunkt 2.2.2", "Menupunkt 2.2.3" };

            for (int menuItem = 0; menuItem < menuItems.GetLength(0); menuItem++)
                menu.AddMenuItem(menuItems[menuItem]);

            while (true)
            {
                menu.Show();

                if (menu.SelectMenuItem() == 0)
                    break;
            }
        }
    }
}
