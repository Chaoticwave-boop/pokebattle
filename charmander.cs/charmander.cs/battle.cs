using poke;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poke
{
    internal class Battle
    {
        public Trainer User;
        public Trainer Rival;

        public Battle(Trainer User, Trainer Rival)
        {
            this.User = User;
            this.Rival = Rival;
        }

        public void battle_results()
        {
            for (int i = 0; i < User.belt.Count; i++)
            {
                Console.WriteLine(User.belt[i].pokemon.name);
                Console.WriteLine("----------");
                Console.WriteLine(Rival.belt[i].pokemon.name);
                if (User.belt[i].pokemon.type == "water" && Rival.belt[i].pokemon.type == "fire"){
                    Console.WriteLine(User.belt[i].pokemon.name);
                }
            }
        }
    }
}
