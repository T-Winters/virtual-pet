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
        public int Max { get; set; } //sets max value for any property
        public int Min { get; set; } //sets minimum amount for pet to be alive

        public bool Alive()// if returned false, game is over
        {
            if (Hunger >= Min && Thirst >= Min && Happiness >= Min && Energy >= Min)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        private int newHunger;
        public int Hunger
        {
            get
            {
                return newHunger;
            }
            set
            {
                newHunger = value;
                if (newHunger > 10)
                {
                    newHunger = Max;
                }
                if (newHunger < Min)
                {
                    Alive();
                }
            }
        }

        private int newThirst;
        public int Thirst
        {
            get
            {
                return newThirst;
            }
            set
            {
                newThirst = value;
                if (newThirst > 10)
                {
                    newThirst = Max;
                }
                if (newThirst < Min)
                {
                    Alive();
                }
            }
        }

        private int newHappiness;
        public int Happiness
        {
            get
            {
                return newHappiness;
            }
            set
            {
                newHappiness = value;
                if (newHappiness > 10)
                {
                    newHappiness = Max;
                }
                if (newHappiness < Min)
                {
                    Alive();
                }
            }
        }

        private int newEnergy;
        public int Energy
        {
            get
            {
                return newEnergy;
            }
            set
            {
                newEnergy = value;
                if (newEnergy > 10)
                {
                    newEnergy = Max;
                }
                if (newEnergy < Min)
                {
                    Alive();
                }
            }
        }

        public VirtualPet()
        {
            Hunger = 7;
            Thirst = 7;
            Happiness = 7;
            Energy = 7;
            Min = 1;
            Max = 10;
            
        }

        public void MainMenu()
        {
            Console.Clear();
            int mainOption = 0;

            StringBuilder main = new StringBuilder();
            main.Append(string.Format(PetName + "\n" + "\nHunger:\t\t" + Hunger + "\nThirst:\t\t" + Thirst + "\nHappiness:\t" + Happiness + "\nEnergy:\t\t" + Energy, Environment.NewLine));
            Console.WriteLine(main.ToString());

            Console.WriteLine("\nWhat would you like to do?");
            StringBuilder options = new StringBuilder();
            options.Append(string.Format("\n" + "\n[1] Feed " + PetName + "\n[2] Give " + PetName + " a drink" + "\n[3] Play with " + PetName + "\n[4] Get some sleep Zzz", Environment.NewLine));
            Console.WriteLine(options.ToString());

            while (Alive())
            {
                string userAction = Console.ReadLine();
                if (userAction == "1" || userAction == "2" || userAction == "3" || userAction == "4")
                {
                    mainOption = Convert.ToInt32(userAction);
                }
                
                if (mainOption == 1)
                {
                    Feed();
                }
                else if (mainOption == 2)
                {
                    Drink();
                }
                else if (mainOption == 3)
                {
                    Play();
                }
                else if (mainOption == 4)
                {
                    Sleep();
                }
                else
                {
                    Console.WriteLine("Sorry, that is not an option. \nPlease select from options 1 - 4.");
                    Console.ReadLine();                    
                }
            }
        }

        public void GameOver()
        {
            if (!Alive())
            {
                Console.WriteLine(PetName + " is unresponsive. :(");
                Console.WriteLine("Game Over..");
                Environment.Exit(0);
            }
            else
            {
                MainMenu();
            }
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
                    Console.WriteLine("\nYUM!\nYou just fed " + PetName + "!");
                }
                else
                {
                    Hunger += 2;
                    Energy -= 1;
                    Thirst -= 1;
                    Happiness += 1;                    
                    Console.WriteLine("\nNUM! NUM! NUM!" + "\n" + PetName + " ate way too much food!");
                }
                Console.WriteLine("Press any button to continue");
                Console.ReadKey();
                MainMenu();
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
                    Console.WriteLine("\nAHH!\nYou just gave" + PetName + " a drink.");
                }
                else
                {
                    Thirst += 2;
                    Hunger -= 1;
                    Happiness += 1;
                    Console.WriteLine("\n AAAHHHH!!!" + "\n" + PetName + "drank until there was nothing left!");
                }
                Console.WriteLine("Press any button to continue");
                Console.ReadKey();
                MainMenu();

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
                Console.WriteLine("Press any button to continue");
                Console.ReadKey();
                MainMenu();

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
                Console.WriteLine("Press any button to continue");
                Console.ReadKey();
                MainMenu();

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
            var timerSleep = new System.Threading.Timer(e => Sleep(), null, TimeSpan.Zero, TimeSpan.FromMinutes(90));
        }                
    }
}
