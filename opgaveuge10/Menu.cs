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
        MenuItem[] menuItems;
        int itemCount;

        // Menu constructor
        public Menu(string title)
        {
            Title = title;
            MenuItems =  new MenuItem[10];
            ItemCount = 0;
        }

        public class MenuItem
        {
            public string Title;

            public MenuItem(string title)
            {
                Title = title;
            }
        }

        public void AddMenuItem(string menuTitle)
        {
            menuItems[itemCount] = new MenuItem(menuTitle);
            itemCount++;
        }

        public void Show()
        {
            Console.WriteLine(Title+"\n\n");

            for (int item = 0; item < itemCount; item++)
                Console.WriteLine($"{item+1}. {menuItems[item].Title}");

            Console.WriteLine("\n\n(Tryk menupunkt eller 0 for at afslutte)");
        }

    }
}
