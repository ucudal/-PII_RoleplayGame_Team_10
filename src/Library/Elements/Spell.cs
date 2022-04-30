using System;

namespace RolePlay
{
    public class Spell
    {
        private string name {get;set;}
        private int defense {get;set;}
        private int damage {get;set;}

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

        public int Defense
        {
            get 
            {
                return this.defense;
            }
        }
        public Spell (string name, int defense, int damage)
        {
            this.name = name;
            this.defense = defense;
            this.damage = damage;
        }
    }    
}