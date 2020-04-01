using System;
using System.Reflection;

namespace TextAdventure
{
    public class Skeleton : ICreature
    {
        public string name = "Skeleton";
        static Random rand = new Random();
        public int health = rand.Next(1,5);
        public int power = rand.Next(1, 3);

        public int Power
        {
            get => power;
            set => power = value;
        }
        public int Health
        {
            get => health;
            set => health = value;
        }
    
    }
}