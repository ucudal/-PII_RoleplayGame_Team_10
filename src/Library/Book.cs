using System;
using System.Collections.Generic;

namespace RolePlay
{
    public class Book
    {
        private string Name {get;set;}
        private List<Spell> spells = new List<Spell>();

        public void addSpell(Spell spellNuevo)
        {
            spells.Add(spellNuevo);
        }
        public void removeSpell(Spell spellViejo)
        {
            spells.Remove(spellViejo);
        }

        public Book(string name)
        {
            this.Name = name;
        }
    }    
}