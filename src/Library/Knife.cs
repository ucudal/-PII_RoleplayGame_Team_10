using System;

namespace Roleplay
{
    public class Knife
    {
        private int damage;
        private string name;

        public Knife(string knifeName, int knifeDamage)
        {
            this.damage = knifeDamage;
            this.name = knifeName;
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
    }
}