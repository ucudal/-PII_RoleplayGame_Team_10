using System;
using System.Collections.Generic;

namespace RolePlay
{
    public class Elf
    {
        private string name;

        private int health;

        private int damage;

        private List<dynamic> elements = new List<dynamic>();







        public Elf(string name, int health, int damage)
        {

            this.Name = name;
            this.Damage = damage;
            this.Health = health;

        }


        public string Name
        {
            get
            {
                return name;
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
                return health;
            }
            set
            {
                this.health = value;
            }
        }
        public int Damage
        {
            get
            {
                return damage;
            }
            set
            {
                this.damage = value;
            }
        }

        public void HealthELf(Elf elf)
        {
            elf.Health += 50;
        }

        public void HealthWizard(Wizard wizard)
        {
            wizard.Health += 50;
        }

        public void HealthDwarf(Dwarf dwarf)
        {
            dwarf.Health += 50;
        }

        public int TotalDamage(){
             int total = this.Damage;
             foreach (dynamic item in elements)
             {
                total += item.damage;
             }
            
            return total;
        }
        public int TotalDefense(){
             
             int total = this.health;
             foreach (dynamic item in elements)
             {
                total += item.health;
             }
            return total;
        }

        public void AddElement(dynamic element)
        {
            element.Add(element);
        }

        public void RemoveElement(dynamic element)
        {
            element.Remove(element);
        }





    }
}