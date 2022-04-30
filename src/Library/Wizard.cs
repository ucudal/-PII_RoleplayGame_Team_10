using System;

namespace RolePlay
{
    public class Wizard
    {
        private string name;
        private int id;

        private int health;

        private int damage;

       // private Book book;


        public Wizard(string name, int id, int health, int damage){
            
            this.Name=name;
            this.Damage=damage;
            this.Id=id;
            this.Health=health;

        }

       /* public Book Book{
            get{
                return Book;
            }
            set{
                this.book=value;
            }
        }*/
        public string Name{
            get{
                return name;
            }
            set{
                this.name=value;
            }
        }

        public int Id{
            get{
                return id;
            }
            set{
                this.id=value;
            }
        }
        public int Health{
            get{
                return health;
            }
            set{
                this.health=value;
            }
        }
        public int Damage{
            get{
                return damage;
            }
            set{
                this.damage=value;
            }
        }

      /*  public void AddBook(Book book){
            this.Book=book;
        }*/

    }
}