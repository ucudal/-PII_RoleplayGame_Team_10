using System;

namespace RolePlay
{
    public class BreastPlate
    {
        private string name;
        private int defense;
        
        public BreastPlate(string name, int defense)
        {
            this.Name = name;
            this.Defense = defense;
        }
        
        public string Name
        {   
            get
            {   
                return name;   
            }
            set 
            {
                this.name=value;
            }
        }  
        public int Defense
        {   
            get
            {
                return defense;
            }
            set
            {
                this.defense=value;
            }
        }
    }
}