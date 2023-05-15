using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poke
{
    internal class Pokemon
    {
        public string name = "charmander";
        public string type = "fire";
        public string weakness = "water";
        public string pokename = "alex";

        public Pokemon() { }

        public Pokemon(string name, string type, string weakness, string pokename)
        {
            this.name = name;
            this.type = type;
            this.weakness = weakness;
            this.pokename = pokename;
        }
    }

    internal class Pokeball
    {
        public string name = "Pokeball";
        public Pokemon pokemon;
        public Pokeball() { }

        public Pokeball(string name, Pokemon pokemon)
        {
            this.name = name;
            this.pokemon = pokemon;
        }
    }

    internal class Trainer
    {
        public string name = "Trainer";
        public List<Pokeball> belt;

        public Trainer() { }

        public Trainer(string name, List<Pokeball> belt)
        {
            this.name = name;
            this.belt = belt;
        }

        public List<Pokeball> getBelt()
        {
            return belt;
        }
    }

}
