using System;

namespace TextAdventure
{
    public class Player
    {
        public string name;
        public int coins = 0;
        public int health = 10;
        public int maxhealth = 10;
        public int armorvalue = 0;
        public int potion = 5;
        public int weaponValue = 1;
        public int amountDefeated = 0;

        static Random rand = new Random();

        public void Run()
        {
            if (rand.Next(0,2) == 0)
            {
                Skeleton skelly = new Skeleton();
                string n = skelly.name;
                Console.WriteLine("you fail to run away. The " + n + " strikes you");
                int damage = skelly.Power - armorvalue;
                Console.WriteLine("you take " + damage + " damage");
                health -= damage;
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("you escape successfully");
                Console.ReadKey();
            }
        }
        
        public void Attack()
        {
            Skeleton skelly = new Skeleton();
            string n = skelly.name;
            Console.WriteLine("You prepare to attack the enemy! The "+n+" strikes first!");
            int damage = skelly.power - armorvalue;
            int attack = weaponValue+ rand.Next(1,4);
            int creatureHealth = skelly.health;
            Console.WriteLine(" you lose "+ damage +" health, your attack deals "+ attack +" damage");
            Console.WriteLine("you take " + damage + " damage");
            health -= damage;
            creatureHealth -= attack;
            Console.ReadKey();

        }
    }
}

    

