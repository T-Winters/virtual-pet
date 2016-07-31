using System;
using System.Collections.Generic;
using System.Timers;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace VirtualPet
{
    class VirtualPet
    {
        public string PetName { get; set; }
        public int Hunger { get; set; }
        public int Thirst { get; set; }
        public int Happiness { get; set; }
        public int Energy { get; set; }
        
        public VirtualPet()
        {
            Hunger = 10;
            Thirst = 10;
            Happiness = 10;
            Energy = 10;
            
        }

        

        public void Feed()
        {
            for (int i = 1; i <= 1; i++)
            {
                if (Hunger >= 10)
                {
                    Console.WriteLine("\nIt looks like " + PetName + " isn't hungry!");
                }
                else if (Hunger < 10 && Hunger > 2)
                {
                    Hunger += 1;
                    Happiness += 1;
                    Energy += 1;
                    Console.WriteLine("\nYUM!\nYou just fed" + PetName + "!");
                }
                else
                {
                    Hunger += 2;
                    Energy -= 1;
                    Thirst -= 1;                    
                    Console.WriteLine("\nNUM! NUM! NU!" + "\n" + PetName + " ate way too much food!");
                }
            }
            TickFeed();
        }

        public void Drink()
        {
            for (int i = 1; i <= 1; i++)
            {
                if (Thirst >= 10)
                {
                    Console.WriteLine("\nIt looks like " + PetName + " isn't thirsty!");
                }
                else if (Thirst < 10 && Thirst > 2)
                {
                    Thirst += 1;
                    Energy += 1;
                    Happiness += 1;
                    Console.WriteLine("\nAHH!\nYou just gave" + PetName + " a drink.");
                }
                else
                {
                    Thirst += 2;
                    Hunger -= 1;
                    Energy += 1;
                    Happiness += 1;
                    Console.WriteLine("\n AAAHHHH!!!" + "\n" + PetName + "drank until there was nothing left!");                    
                }
            }
            TickDrink();
        }

        public void Play()
        {
            for (int i = 1; i <= 1; i++)
            {
                if (Happiness >= 10)
                {
                    Console.WriteLine("\n" + PetName + " has never been more happy!");
                }
                else if (Happiness < 10 && Happiness > 2 && Energy > 2)
                {
                    Happiness += 2;
                    Energy -= 1;
                    Hunger -= 1;
                    Thirst -= 1;
                    Console.WriteLine("\nWooo! That was fun!" + "\n" + PetName + " had a great time playing with you!");
                }
                else if (Happiness < 10 && Happiness > 2 && Energy <= 2)
                {
                    Happiness += 2;
                    Hunger -= 1;
                    Thirst -= 1;
                    Console.WriteLine("\nThat was fun!" + "\n" + PetName + " had fun, but was too tired to play for a long time.");
                }
                else if (Happiness <= 2 && Energy > 2)
                {
                    Happiness += 2;
                    Energy -= 1;
                    Hunger -= 1;
                    Thirst -= 1;
                    Console.WriteLine("\nWooo! That was fun!" + "\n" + PetName + " had a great time playing with you!");
                }
                else
                {
                    Happiness += 2;
                    Hunger -= 1;
                    Thirst -= 1;
                    Console.WriteLine("\nThat was fun!" + "\n" + PetName + " had fun, but was too tired to play for a long time.");
                }
            }
            TickPlay();
        }

        public void Sleep()
        {
            for (int i = 1; i <= 1; i++)
            {
                if (Energy >= 10)
                {
                    Console.WriteLine("\n" + PetName + " has never been more happy!");
                }
                else if (Energy < 10 && Energy >= 8)
                {
                    Energy += 1;                    
                    Console.WriteLine("\nZzz.." + "\n" + PetName + " enjoyed a quick nap!");
                }
                else
                {
                    Energy += 2;
                    Console.WriteLine("\nZZZzzz...." + "\n" + PetName + " slept great!");
                }
            }
            TickSleep();
        }

        private void TickFeed()
        {
            for (int i = 1; i <= 1; i++)
            {
                Hunger -= 1;
            }
            var timerFeed = new System.Threading.Timer(e => TickFeed(), null, TimeSpan.Zero, TimeSpan.FromMinutes(120));
        }    
        
        private void TickDrink()
        {
            for (int i = 1; i <= 1; i++)
            {
                Thirst -= 1;
            }
            var timerDrink = new System.Threading.Timer(e => Drink(), null, TimeSpan.Zero, TimeSpan.FromMinutes(120));
        }

        private void TickPlay()
        {
            for (int i = 1; i <= 1; i++)
            {
                Happiness -= 1;
            }
            var timerPlay = new System.Threading.Timer(e => Play(), null, TimeSpan.Zero, TimeSpan.FromMinutes(240));
        }

        private void TickSleep()
        {
            for (int i = 1; i <= 1; i++)
            {
                Energy -= 1;
            }
            var timerSleep = new System.Threading.Timer(e => Sleep(), null, TimeSpan.Zero, TimeSpan.FromMinutes(90)); */

        }






    }
}
