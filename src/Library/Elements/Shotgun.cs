using System;

namespace RolePlay
{
    public class Shotgun
    {
        private string name;
        private int damage = 100;

        private int health = 0;
        
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
        public Shotgun(string name)
        {
            this.Name = name;
        }
    }    
}