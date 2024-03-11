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
        SubMenuItem[] subMenuItems = new SubMenuItem[100]; // maksimum 100 menumpunkter
        int itemCount;

        // Menu constructor
        public Menu(string title)
        {
            Title = title;
            itemCount = 0;
        }

        public class SubMenuItem
        {
            public string Title;
            SubMenuItem[] subMenuItems = new SubMenuItem[100];
            int itemCount;

            public SubMenuItem(string title)
            {
                Title = title;
                itemCount = 0;
            }

            public void AddSubMenuItem(string subMenuTitle)
            {
                subMenuItems[itemCount] = new SubMenuItem(subMenuTitle);
                itemCount++;
            }

        }

        public void AddMenuItem(string menuTitle)
        {
            subMenuItems[itemCount] = new SubMenuItem(menuTitle);
            itemCount++;
        }

        public void Show()
        {
            Console.WriteLine(Title+"\n\n");

            for (int item = 0; item < itemCount; item++)
                Console.WriteLine($"{item+1}. {subMenuItems[item].Title}");

            Console.Write("\n\n(Tryk menupunkt eller 0 for at afslutte) ");

        }

        public int SelectMenuItem()
        {
            int selectedMenuItem;

            while (true) 
            {
                if (int.TryParse(Console.ReadLine(), out selectedMenuItem) && selectedMenuItem <= itemCount && selectedMenuItem >= 0)
                    return selectedMenuItem;

                else
                    Console.Write("Dit valg af menupunkt eksisterer ikke. Prøv igen: ");
            }
        }
    }
}
