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
        public string type = "fire";
        public string weakness = "water";
        public string pokename = "charmander";

        public pokemon() { }

        public pokemon(string name, string type, string weakness, string pokename)
        {
            this.name = name;
            this.type = type;
            this.weakness = weakness;
            this.pokename = pokename;
        }
    }
}
