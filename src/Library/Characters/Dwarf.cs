using System;
using System.Collections.Generic;

namespace RolePlay
{
    public class Dwarf
    {
        private string name;

        private int health;

        private int damage;

        private List<dynamic> elements = new List<dynamic>();



        public Dwarf(string name,int damage, int health)
        {
            this.Name = name;
            this.Health = health;
            this.Damage = damage;
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