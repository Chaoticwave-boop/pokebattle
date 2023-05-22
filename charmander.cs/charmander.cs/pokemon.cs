using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poke
{
    public abstract class Pokemon
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


    public class Charmander : Pokemon { 
        public Charmander(String pokename) : base("Charmander", "Fire", "Water",pokename) { }
        public override void Scream()
        {
            Console.WriteLine("Charmander!");
        }
    }


    public class Squirtle : Pokemon
    {
        public Squirtle(String pokename) : base("Squirtle", "Water", "Grass", pokename) { }
        public override void Scream()
        {
            Console.WriteLine("Squirtle!");
        }
    }

    public class Bulbasaur : Pokemon
    {
        public Bulbasaur(String pokename) : base("Bulbasaur", "Grass", "Fire", pokename) { }
        public override void Scream()
        {
            Console.WriteLine(" Bulbasaur!");
        }
    }
}
