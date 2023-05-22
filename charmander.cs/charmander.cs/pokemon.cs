using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poke
{
    internal abstract class Pokemon
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
        public abstract void Scream();
    }


    internal class Charmander : Pokemon { 
        public Charmander(string name,string pokename) : base(name, "Fire", "Water", pokename) { }
        public override void Scream()
        {
            Console.WriteLine("Charmander!");
        }
    }


    internal class Squirtle : Pokemon
    {
        public Squirtle(string name, string pokename) : base(name, "Water", "Grass", pokename) { }
        public override void Scream()
        {
            Console.WriteLine("Squirtle!");
        }
    }

    internal class Bulbasaur : Pokemon
    {
        public Bulbasaur(string name, string pokename) : base(name, "Grass", "Fire", pokename) { }
        public override void Scream()
        {
            Console.WriteLine(" Bulbasaur!");
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
