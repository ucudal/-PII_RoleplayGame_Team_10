using System;

namespace RolePlay
{
    public class Dwarf
    {
        private string name;

        private int health;
        private Weapon weapon;


        public Dwarf(string name, int health, Weapon weapon)
        {
            this.Name = name;
            this.Health = health;
            this.Weapon = weapon;
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

        public int Health
        {
            get
            {
                return this.health;
            }
            
            set
            {
                this.health = value;
            }
        }

        public Weapon Weapon
        {
            get
            {
                return this.weapon;
            }
            
            set
            {
                this.weapon = value;
            }
        }
    }
}