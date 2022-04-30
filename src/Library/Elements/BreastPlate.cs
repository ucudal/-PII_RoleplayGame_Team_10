using System;

namespace RolePlay
{
    public class BreastPlate
    {
        private string name;
        private int health = 100;

        private int damage = 0;
        
        public BreastPlate(string name)
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