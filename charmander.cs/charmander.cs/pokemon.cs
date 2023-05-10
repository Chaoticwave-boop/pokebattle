using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poke
{
    internal class pokemon
    {
        public string name;
        public string strenght = "fire";
        public string weakness = "water";
        public string pokename = "charmander";

        public pokemon() { }

        public pokemon(string name, string strenght, string weakness, string pokename)
        {
            this.name = name;
            this.strenght = strenght;
            this.weakness = weakness;
            this.pokename = pokename;
        }
    }
}
