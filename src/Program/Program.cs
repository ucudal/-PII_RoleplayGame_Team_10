using System;

namespace RolePlay
{
    class Program
    {
        static void Main(string[] args)
        {

            Weapon bow = new Weapon("Special Bow", 25, 0);
            
            Dwarf dwarfExample = new Dwarf("Ragnar", 100, bow);
            Console.WriteLine ($"Dwarf name: {dwarfExample.Name}\nDwarf life: {dwarfExample.Health}\nDwarf weapon: {dwarfExample.Weapon.Name} with {dwarfExample.Weapon.Damage} damage and {dwarfExample.Weapon.Armor} of protection. ");

            Weapon shield = new Weapon("Captain America Shield", 10, 40);
            Dwarf pitufo = new Dwarf("Pitufo", 100, shield);
            Console.WriteLine ($"Dwarf name: {pitufo.Name}\nDwarf life: {pitufo.Health}\nDwarf weapon: {pitufo.Weapon.Name} with {pitufo.Weapon.Damage} damage and {pitufo.Weapon.Armor} of protection. ");
        }
    }
}
