using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            VirtualPet Sandy = new VirtualPet("Sandy", 10, 10, 10,10);
            Sandy.print();
        }
    }
}
