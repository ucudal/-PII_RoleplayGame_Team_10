using System;

namespace RolePlay
{
    public class Helmet
    {
        private string name;

        private int health = 100;

        private int damage = 0;

        
        public Helmet(string name)
        {
            this.Name = name;
            
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