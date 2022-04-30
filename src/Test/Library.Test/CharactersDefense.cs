using NUnit.Framework;

namespace RolePlay
{


    public class GetTotalDefense
    {

        [Test]
        public void DwarfDefense()
        {
            Dwarf dwarf1 = new Dwarf ("Grunge",50,100);
            Shield item1 = new Shield ();
            dwarf1.AddElement(item1);
            dwarf1.Thealth = dwarf1.health+dwarf1(item.health);
            dwarf1.TotalDefense = 200;
            Assert.AreEqual (dwarf1.Thealth,dwarf1.TotalDefense);
            
        }
        
        [Test]
        public void ElfDefense()
        {
            Elf elf1 = new Elf ("Amil",50,100);
            Shield item1 = new Shield ();
            BreastPlate item2 = new BreastPlate ();
            elf1.AddElement(item1);
            elf1.AddElement(item2);
            elf1.Thealth = elf1.health+elf1(item.health);
            elf1.TotalDefense = 300;
            Assert.AreEqual (elf1.Thealth,elf1.TotalDefense);
            
        }
        
        [Test]
        public void WizardDefense()
        {
            Wizard wizard1 = new Wizard ("Amil",50,150);
            Shield item1 = new Shield ();
            Helmet item2 = new Helmet ();
            wizard1.AddElement(item1);
            wizard1.AddElement(item2);
            wizard1.Thealth = wizard1.health+wizard1(item.health);
            wizard1.TotalDefense = 350;
            Assert.AreEqual (wizard1.Thealth,wizard1.TotalDefense);
            
        }
        
        

    }


}