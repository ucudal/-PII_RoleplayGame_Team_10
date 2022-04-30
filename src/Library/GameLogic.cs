using System;
using System.Collections.Generic;

namespace RolePlay
{
    public class GameLogic
    {


        public void Wizard_Attack_Wizard(Wizard wizard1, Wizard wizard2)
        {
            wizard2.Health = wizard2.TotalDefense() - wizard1.TotalDamage(); 
        }

        public void Wizard_Attack_Elf(Wizard wizard1, Elf elf)
        {
            elf.Health = elf.TotalDefense() - wizard1.TotalDamage();
        }

        public void Wizard_Attack_Dwarf(Wizard wizard1, Dwarf dwarf)
        {
            dwarf.Health = dwarf.TotalDefense() - wizard1.TotalDamage();
        }

        public void Elf_Attack_Wizard(Elf elf, Wizard wizard)
        {
            wizard.Health = wizard.TotalDefense() - elf.TotalDamage();
        }

        public void Elf_Attack_Elf(Elf elf, Elf elf2)
        {
            elf2.Health = elf2.TotalDefense() - elf.TotalDamage();
        }

        public void Elf_Attack_Dwarf(Elf elf, Dwarf dwarf)
        {
            dwarf.Health = dwarf.TotalDefense() - elf.TotalDamage();
        }

        public void Dwarf_Attack_Dwarf(Dwarf dwarf, Dwarf dwarf2)
        {
            dwarf2.Health = dwarf2.TotalDefense() - dwarf.TotalDamage();
        }

        public void Dwarf_Attack_Elf(Dwarf dwarf,Elf elf)
        {
            elf.Health = elf.TotalDefense() - dwarf.TotalDamage();
        }

        public void Dwarf_Attack_Wizard(Dwarf dwarf,Wizard wizard)
        {
            wizard.Health = wizard.TotalDefense() - dwarf.TotalDamage();
        }

        public void Total_Health_Wizard(Wizard wizard)
        {
            wizard.Health=100;
        }
        public void Total_Health_Elf(Elf elf)
        {
            elf.Health=100;
        }
        public void Total_Health_Dwarf(Dwarf dwarf)
        {
            dwarf.Health=100;
        }

        






    }
}