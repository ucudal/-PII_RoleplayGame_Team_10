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
            //Shield item1 = new Shield ();
            //dwarf1.AddElement(item1);
            Assert.AreEqual(dwarf1.TotalDefense,100);
            
        }
        
        [Test]
        public void ElfDefense()
        {
            Elf elf1 = new Elf ("Amil",100,50);
            //Shield item1 = new Shield ();
            //BreastPlate item2 = new BreastPlate ();
            //elf1.AddElement(item1);
            //elf1.AddElement(item2);
            Assert.AreEqual (elf1.TotalDefense,100);
            
        }
        
        [Test]
        public void WizardDefense()
        {
            Wizard wizard1 = new Wizard ("Adil",150,50);
            //Shield item1 = new Shield ();
            //Helmet item2 = new Helmet ();
            //wizard1.AddElement(item1);
            //wizard1.AddElement(item2);
            Assert.AreEqual (wizard1.TotalDefense,150);
            
        }
    }
}