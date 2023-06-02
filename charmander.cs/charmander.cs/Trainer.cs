using poke;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poke
{
    public class Trainer
    {
        private string name = "Trainer";
        private List<Pokeball> belt = new List<Pokeball>(6);

        public Trainer() { }

        public Trainer(string name)
        {
            this.name = name;
        }

        public List<Pokeball> getBelt()
        {
            return belt;
        }

        public string getName()
        {
            return name;
        }

        public void AddPokemon(String pokeballtype, Pokemon pokemon)
        {
            this.belt.Add(new Pokeball("pokeball", pokemon));
        }
    }
}
