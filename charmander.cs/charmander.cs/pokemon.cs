using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poke
{
    internal class pokemon
    {
        public string name = "charmander";
        public string type = "fire";
        public string weakness = "water";
        public string pokename;

        public pokemon() { }

        public pokemon(string name, string type, string weakness, string pokename)
        {
            this.name = name;
            this.type = type;
            this.weakness = weakness;
            this.pokename = pokename;
        }
    }

    internal class pokeball
    {
        public string name = "Pokeball";
        public string pokename = "";
        public string content = "charmander";
        public bool open = false
        
        public pokeball() { }

        public pokeball(string name,string pokename ,string content, bool open)
        {
            this.name = name;
            this.pokename = pokename;
            this.content= content;
            this.open = open;
           
        }
    }

}
