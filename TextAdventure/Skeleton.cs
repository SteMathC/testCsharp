using System;
using System.Reflection;

namespace TextAdventure
{
    public class Skeleton : ICreature
    {
        static Random rand = new Random();
        public int health = rand.Next(1,5);

        public int Power
        {
            get => Power;
            set => Power = value;
        }
        public int Health
        {
            get => health;
            set => health = value;
        }
    
    }
}