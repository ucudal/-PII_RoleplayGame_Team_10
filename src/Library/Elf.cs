using System;

namespace RolePlay
{
    public class Elf
    {
        private string name;
        private int id;

        private int health;

        private int damage;



        public Elf(string name, int id, int health, int damage){
            
            this.Name=name;
            this.Damage=damage;
            this.Id=id;
            this.Health=health;

        }


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


    }
}