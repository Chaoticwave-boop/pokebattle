﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poke
{

    public abstract class Pokemon
    {
        public enum Type
        {
            Grass,
            Fire,
            Water
        }
        
        private string name;  // this name still changes so its not a readonly 
        private readonly Type type;
        private readonly Type weakness;
        private string pokename = "alex";

        public Pokemon() { }

        public Pokemon(string name, Type type, Type weakness, string pokename)
        {
            this.name = name;
            this.type = type;
            this.weakness = weakness;
            this.pokename = pokename;
        }
        public abstract void Scream();

        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public Type getWeakness()
        {
            return weakness;
        }
    

        public Type getType() {
            return type;
        }

    
    }


    public class Charmander : Pokemon { 
        public Charmander(String pokename) : base("Charmander", Type.Fire, Type.Water, pokename) { }
        public override void Scream()
        {
            Console.WriteLine("Charmander!");
        }
    }


    public class Squirtle : Pokemon
    {
        public Squirtle(String pokename) : base("Squirtle", Type.Water, Type.Grass, pokename) { }
        public override void Scream()
        {
            Console.WriteLine("Squirtle!");
        }
    }

    public class Bulbasaur : Pokemon
    {
        public Bulbasaur(String pokename) : base("Bulbasaur", Type.Grass,  Type.Fire, pokename) { }
        public override void Scream()
        {
            Console.WriteLine(" Bulbasaur!");
        }
    }
}
