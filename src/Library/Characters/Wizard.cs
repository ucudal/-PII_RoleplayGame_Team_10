using System;
using System.Collections.Generic;

namespace RolePlay
{
    public class Wizard
    {
        private string name;

        private int health;

        private int damage;

        private Book book;

        private List<dynamic> elements = new List<dynamic>();

        public Wizard(string name, int health, int damage)
        {

            this.Name = name;
            this.Damage = damage;
            this.Health = health;

        }

        public Book Book
        {
            get
            {
                return Book;
            }
            set
            {
                this.book = value;
            }
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

        public void AddBook(Book book)
        {
            this.Book = book;
        }

        public int TotalDamage(){
             int total = this.Damage;
             foreach (dynamic item in elements)
             {
                total += item.Damage;
             }
            
            return total;
        }
        public int TotalDefense(){
             
             int total = this.health;
             foreach (dynamic item in elements)
             {
                total += item.Health;
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