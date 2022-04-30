using System;

namespace RolePlay
{
    public class InfinityGems
    {

        private string name;
        private int damage = 100;
        private int health = 100;

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
        public InfinityGems(string name)
        {
            this.Name = name;
        }
    }    
}