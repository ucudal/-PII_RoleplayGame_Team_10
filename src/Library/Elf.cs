using System;

namespace RolePlay
{
    public class Elf
    {
        private string name;
        private int id;

        private int health;

        private int damage;

        private BreastPlate Pechera{get;set;}

        private Sword espada {get;set;}

        private Shield escudo {get;set;}

        private Helmet casco {get;set;}



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




    }
}