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
            elf.Health = elf.TotalDefense() - wizard1.TotalDamage();
        }

        public void Wizard_Atack_Dwarf(Wizard wizard1, Dwarf dwarf)
        {
            dwarf.Health = dwarf.TotalDefense() - wizard1.TotalDamage();
        }

        public void Elf_Atack_Wizard(Elf elf, Wizard wizard)
        {
            wizard.Health = wizard.TotalDefense() - elf.TotalDamage();
        }

        public void Elf_Atack_Elf(Elf elf, Elf elf2)
        {
            elf2.Health = elf2.TotalDefense() - elf.TotalDamage();
        }

        public void Elf_Atack_Dwarf(Elf elf, Dwarf dwarf)
        {
            dwarf.Health = dwarf.TotalDefense() - elf.TotalDamage();
        }

        public void Dwarf_Atack_Dwarf(Dwarf dwarf, Dwarf dwarf2)
        {
            dwarf2.Health = dwarf2.TotalDefense() - dwarf.TotalDamage();
        }

        public void Dwarf_Atack_Elf(Dwarf dwarf,Elf elf)
        {
            elf.Health = elf.TotalDefense() - dwarf.TotalDamage();
        }

        public void Dwarf_Atack_Wizard(Dwarf dwarf,Wizard wizard)
        {
            wizard.Health = wizard.TotalDefense() - dwarf.TotalDamage();
        }

        

        






    }
}