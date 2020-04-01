using System;
using System.Reflection;

namespace TextAdventure
{
    public class Skeleton : ICreature
    {
        static Random rand = new Random();
        public int health;

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