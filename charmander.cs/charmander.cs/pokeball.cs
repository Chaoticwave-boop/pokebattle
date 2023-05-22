using poke;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poke
{

    public class Pokeball
    {
    
        public string name = "Pokeball";
        public Pokemon pokemon;
       

        public Pokeball(string name, Pokemon pokemon)
        {
            this.name = name;
            this.pokemon = pokemon;
        }
    }
}
