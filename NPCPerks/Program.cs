using System;

namespace NPCPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask user for number, initialize variable and convert to int
            Console.WriteLine("How many NPCs do you want?");
            string number = Console.ReadLine();
            int num = Convert.ToInt32(number);
            Class1[] carat;
       

            Console.WriteLine("Each NPC can have 4 categories:" +
                "\nStealth \nCombat \nLockpick \nLuck");

            carat = new Class1[num];
            
            // ask for the characteristics per NPC
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"what characteristics do you want for NPC {i}?");
                string answer = Console.ReadLine();

                if (answer == "stealth")
                    carat[i] |= Class1.Stealth;

                if (answer == "combat")
                    carat[i] |= Class1.Combat;

                if (answer == "lockpick")
                    carat[i] |= Class1.Lockpick;

                if (answer == "luck")
                    carat[i] |= Class1.Luck;

            }

            for (int i = 0; i < num; i++)
            {
       
             Console.WriteLine(carat[i]);

            }
        }
    }
}
