using System;

namespace RolePlay
{
    public class Shield
    {
        private string name;

        private int health = 100;

        private int damage;
        
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
        public Shield(string name)
        {
            this.Name = name;
        }

    }    
}