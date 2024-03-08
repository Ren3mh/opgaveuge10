using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgaveuge10
{
    

    internal class Menu
    {
        public string Title;
        MenuItem[] menuItems = new MenuItem[3]; // maksimum 100 menumpunkter
        int itemCount;

        // Menu constructor
        public Menu(string title)
        {
            Title = title;
            itemCount = 0;
        }

        public class MenuItem
        {
            public string Title;
            public string PrintThis;

            public MenuItem(string title, string printThis)
            {
                Title = title;
                PrintThis = printThis;
            }
        }

        public void AddMenuItem(string menuTitle, string menuPrint)
        {
            menuItems[itemCount] = new MenuItem(menuTitle, menuPrint);
            itemCount++;
        }

        public void Show()
        {
            Console.WriteLine(Title+"\n\n");

            for (int item = 0; item < itemCount; item++)
                Console.WriteLine($"{item+1}. {menuItems[item].Title}");

            Console.Write("\n\n(Tryk menupunkt eller 0 for at afslutte) ");

        }

        public void SelectMenuItem()
        {
            int selectedMenuItem;

            while (true) 
            {

                if (int.TryParse(Console.ReadLine(), out selectedMenuItem) && selectedMenuItem <= itemCount && selectedMenuItem >= 0)
                    break;

                Console.Write("Dit valg af menupunkt eksisterer ikke. Prøv igen: ");
            }

            string message = menuItems[selectedMenuItem -1].PrintThis;

            Console.WriteLine(message);
        }
    }
}
