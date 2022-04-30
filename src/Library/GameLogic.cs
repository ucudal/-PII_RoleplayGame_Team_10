using System;
using System.Collections.Generic;

namespace RolePlay
{
    public class GameLogic
    {


        public void Wizard_Atack_Wizard(Wizard wizard1, Wizard wizard2)
        {
            wizard2.Health = wizard2.TotalDefense() - wizard1.TotalDamage(); 
        }

        public void Wizard_Atack_Elf(Wizard wizard1, Elf elf)
        {

        }

        public void Wizard_Atack_Dwarf(Wizard wizard1, Dwarf dwarf)
        {

        }

        public void Elf_Atack_Wizard(Elf elf, Wizard wizard)
        {

        }

        public void Elf_Atack_Elf(Elf elf, Elf elf2)
        {

        }

        public void Elf_Atack_Dwarf(Elf elf, Dwarf dwarf)
        {

        }

        public void Dwarf_Atack_Dwarf(Dwarf dwarf, Dwarf dwarf2)
        {

        }

        public void Dwarf_Atack_Elf(Dwarf dwarf,Elf elf)
        {

        }

        public void Dwarf_Atack_Wizard(Dwarf dwarf,Wizard wizard)
        {

        }

        






    }
}