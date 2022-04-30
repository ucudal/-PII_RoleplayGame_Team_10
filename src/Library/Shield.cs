using System;

namespace RolePlay
{
    public class Shield
    {
        private string name;
        private int defense = 100;
        
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

        public int Defense
        {
            get 
            {
                return this.defense;
            }
        }
        public Shield(string name)
        {
            this.Name = name;
        }
    }    
}