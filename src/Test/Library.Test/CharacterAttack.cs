using NUnit.Framework;
using RolePlay;

namespace Test.Library
{


    public class ExampleTest
    {

        [Test]
        public void DwarfAttackDwarf()
        {
            Dwarf gruñon = new Dwarf("Gruñon", 12, 100);
            Dwarf happy = new Dwarf("HappyDwarf", 7, 100);

            GameLogic gameLogic = new GameLogic();
            gameLogic.Dwarf_Atack_Dwarf(gruñon, happy);
            Assert.AreEqual(93, gruñon.Health);
        }

        [Test]
        public void DwarfAttackElf()
        {
            Dwarf gruñon = new Dwarf("Gruñon", 12, 100);
            Elf harry = new Elf("Ferb", 11, 100);

            GameLogic gameLogic = new GameLogic();
            gameLogic.Dwarf_Atack_Elf(gruñon, harry);
            Assert.AreEqual(88, gruñon.Health);
        }


}


}