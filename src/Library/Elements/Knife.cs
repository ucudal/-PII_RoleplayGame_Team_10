using System;

namespace Roleplay
{
    public class Knife
    {
        private int damage = 100;
        private string name;

        private int health = 0;

        public Knife(string knifeName)
        {
            this.name = knifeName;
        }

         public string Name
        {
            set
            {
                this.name = value;
            }
            get 
            {
                return this.name;
            }
        }
        public int Damage
        {
            get 
            {
                return this.damage;
            }
        }

        public int Health
        {
            get 
            {
                return this.health;
            }
        }
    }
}