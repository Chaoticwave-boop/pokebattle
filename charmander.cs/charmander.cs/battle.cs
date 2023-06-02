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

        public int Userint = 0;
        public int Rivalint = 0;



        public Battle(Trainer User, Trainer Rival)
        {
            this.User = User;
            this.Rival = Rival;
        }

        public void battle_results()
        {
            Console.WriteLine(Rival.belt[Rivalint].pokemon.name + " is released ");
            Console.WriteLine(User.belt[Userint].pokemon.name + " is released ");

            while (true)
            { 
                Thread.Sleep(2000);
                if (Userint == User.belt.Count && Rivalint == Rival.belt.Count)
                {
                    Console.WriteLine("everybody wins :D");
                    break;
                }
                else if (Userint == User.belt.Count)
                {
                    Console.WriteLine(Rival.name + " won ");
                    break;
                }
                else if (Rivalint == Rival.belt.Count)
                {
                    Console.WriteLine(User.name + " won ");
                    break;
                }

                if (User.belt[Userint].pokemon.type == Rival.belt[Rivalint].pokemon.type)
                {
                    Console.WriteLine("its a draw");
                    Rivalint++;
                    Userint++;
                
                }
                else if (User.belt[Userint].pokemon.type == "Water" && Rival.belt[Rivalint].pokemon.type == "Fire"){
                    Console.WriteLine(Rival.belt[Rivalint].pokemon.name + " faints");
                    Rivalint++;
                }
                else if (User.belt[Userint].pokemon.type == "Fire" && Rival.belt[Rivalint].pokemon.type == "Water")
                {
                    Console.WriteLine(User.belt[Userint].pokemon.name + " faints");
                    Userint++;
                }
                else if (User.belt[Userint].pokemon.type == "Fire" && Rival.belt[Rivalint].pokemon.type == "Grass")
                {
                    Console.WriteLine(Rival.belt[Rivalint].pokemon.name + " faints");
                    Rivalint++;
                }
                else if (User.belt[Userint].pokemon.type == "Grass" && Rival.belt[Rivalint].pokemon.type == "Fire")
                {
                    Console.WriteLine(User.belt[Userint].pokemon.name + " faints");
                    Userint++;
                }
                else if (User.belt[Userint].pokemon.type == "Grass" && Rival.belt[Rivalint].pokemon.type == "Water")
                {
                    Console.WriteLine(Rival.belt[Rivalint].pokemon.name + " faints");
                    Rivalint++;
                }
                else if (User.belt[Userint].pokemon.type == "Water" && Rival.belt[Rivalint].pokemon.type == "Grass")
                {
                    Console.WriteLine(User.belt[Userint].pokemon.name + " faints");
                    Userint++;
                }

            }
        }
    }
}
