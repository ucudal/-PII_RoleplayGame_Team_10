using System;

namespace RolePlay
{
    public class Sword
    {
        private string name;

        private int damage = 100;
        
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

        public Sword(string name)
        {
            this.Name = name;
        }
    }    
}