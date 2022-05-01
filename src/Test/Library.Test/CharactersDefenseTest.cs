using NUnit.Framework;
using System.Collections.Generic;
using RolePlay;

namespace Test.Library
{
    public class GetTotalDefense
    {
        [Test]
        public void DwarfDefense()
        {
            Dwarf dwarf1 = new Dwarf ("Grunge",50,100);
            Shield item1 = new Shield ("Shield");
            dwarf1.AddElements(item1);
            totalhealth = 200;
            Assert.AreEqual(totalhealth,dwarf1.TotalDefense());
            
        }
        
        [Test]
        public void ElfDefense()
        {
            Elf elf1 = new Elf ("Amil",100,50);
            Shield item1 = new Shield ("Shield");
            BreastPlate item2 = new BreastPlate ("BreastPlate");
            elf1.AddElements(item1);
            elf1.AddElements(item2);
            totalhealth = 300;
            Assert.AreEqual(totalhealth,elf1.TotalDefense());
            
        }
        
        [Test]
        public void WizardDefense()
        {
            Wizard wizard1 = new Wizard ("Adil",150,50);
            Shield item1 = new Shield ("Shield");
            Helmet item2 = new Helmet ("Helmet");
            wizard1.AddElement(item1);
            wizard1.AddElement(item2);
            totalhealth = 350;
            Assert.AreEqual (totalhealth,wizard1.TotalDefense());
            
        }
    }
}