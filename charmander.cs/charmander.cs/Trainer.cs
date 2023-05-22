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
