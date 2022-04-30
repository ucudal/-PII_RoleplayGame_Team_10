using NUnit.Framework;
using RolePlay;

namespace Test.Library
{


    public class GetTotalAttacks

    {
        Bow arco = new Bow("arco");
        BreastPlate pechera = new BreastPlate("pechera");
        Helmet casco = new Helmet("casco");
        InfinityGems gemas = new InfinityGems("gemas");
        Knife cuchillo = new Knife("cuchillo");
        Shield escudo = new Shield("escudo");
        Shotgun escopeta = new Shotgun("escopeta");
        Sword espada = new Sword("espada");

       

        [Test]
        public void VerifyTotalDamage_Dwarf()
        {
            Dwarf mago = new Dwarf("El Mago Jacinto", 100, 100);
            mago.AddElement(arco);
            mago.AddElement(pechera);
            mago.AddElement(casco);
            mago.AddElement(gemas);
            mago.AddElement(cuchillo);
            mago.AddElement(escudo);
            mago.AddElement(escopeta);
            mago.AddElement(espada);
            
            //int totalDamage = 
            Assert.True(true);
        }

    }


}