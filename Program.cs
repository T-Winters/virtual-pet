using System;
using System.Collections.Generic;
using System.Timers;
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

            //WELCOME

            Console.WriteLine("\nWhat is the name of your pet?");
            myVirtualPet.PetName = Console.ReadLine();

        }
    }
}
