using System;

namespace TextAdventure
{
    public class Player
    {
        public string name;
        public int coins =0;
        public int health = 10;
        public int maxhealth = 10;
        public int armorvalue = 0;
        public int potion = 5;
        public int weaponValue = 1;
        public int amountDefeated = 0;
        
        static Random rand = new Random();
        
        Skeleton skelly = new Skeleton();
       
        public void run() {
            if (rand.Next(0, 2) == 0)
            {
               Console.WriteLine("you fail to run away. The" + n + " strikes you");
            }

            {
                
            }
        }
    }
    
  
    
    
}
