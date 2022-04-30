using System;

namespace Roleplay
{
    public class Bow
    {
        private int damage;
        private string name;

        public Bow(string bowName, int bowDamage)
        {
            this.damage = bowDamage;
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
            
            set
            {
                this.damage = value;
            }
        }
    }
}