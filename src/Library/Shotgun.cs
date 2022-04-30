using System;

namespace RolePlay
{
    public class Shotgun
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

        public Shotgun(string name)
        {
            this.Name = name;
        }
    }    
}