using System;

namespace Library
{
    public class Weapon
    {
        private string name;
        private int damage;
        private int armor;
        public Weapon(string name, int damage, int armor)
        {
            this.Name = name;
            this.Damage = damage;
            this.Armor = armor;
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
            set 
            {
                this.damage = value;
            }
        }

        public int Armor
        {
            get 
            {
                return this.armor;
            }
            set 
            {
                this.armor = value;
            }
        }  
    }
}