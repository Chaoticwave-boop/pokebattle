using poke;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poke
{

    public sealed class Pokeball
    {
    
        public readonly string name = "Pokeball";
        private readonly Pokemon pokemon;
        private bool isOpen;
       
        public Pokeball(string name, Pokemon pokemon)
        {
            this.name = name;
            this.pokemon = pokemon;
        }
        public Pokemon getPokemonInBall()
        {
            // maybe add here the if statement for it he ball is closed or not
            return this.pokemon;
        }

        public string OpenBall()
        {
            this.isOpen = true;
            return $"released {this.pokemon.getName()}";
        }
        public string CloseBall()
        {
            this.isOpen = false;
            return $"returns {this.pokemon.getName()}";
        }
        // method open
            // releases pokemon
            // check if pokeball is empty or not
        // method close
            // return pokemon

    }
}
