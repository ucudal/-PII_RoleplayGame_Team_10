using System;

namespace RolePlay
{
    public class Bow
    {
        private int damage = 100;
        private string name;
        private int health = 0;

        public Bow(string bowName)
        {
            this.name = bowName;
        }

      public string Name
        {
            get
            {
                return this.name;
            }
            
            set
            {
                this.name = value;
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