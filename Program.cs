using System;
using System.Collections.Generic;
using System.Timers;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            VirtualPet myVirtualPet = new VirtualPet();

            Console.WriteLine("Let's get started!");
            Console.WriteLine("\nWhat is the name of your pet?");
            myVirtualPet.PetName = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(Console.ReadLine());

            while (myVirtualPet.Alive())
            {
                myVirtualPet.MainMenu();
            }

        }
    }
}
