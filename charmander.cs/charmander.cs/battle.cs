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

        public void  battle_results()
        {
            Console.WriteLine(Rival.name + " released " + Rival.belt[Rivalint].pokemon.name);
            Console.WriteLine(User.name + " released " + User.belt[Userint].pokemon.name);

            while (true)
            { 
                Thread.Sleep(2000);
                if (Userint >= User.belt.Count && Rivalint >= Rival.belt.Count)
                {
                    Console.WriteLine("everybody wins :D");
                    break;
                }
                else if (Userint >= User.belt.Count)
                {
                    Console.WriteLine(Rival.name + " won ");
                    break;
                }
                else if (Rivalint >= Rival.belt.Count)
                {
                    Console.WriteLine(User.name + " won ");
                    break;
                }

                if (User.belt[Userint].pokemon.getType() == Rival.belt[Rivalint].pokemon.getType())
                {
                    Console.WriteLine("its a draw");
                    Rivalint++;
                    Userint++;
                }
                else if (User.belt[Userint].pokemon.getType() == Rival.belt[Rivalint].pokemon.getWeakness())
                {
                    Console.WriteLine(Rival.belt[Rivalint].pokemon.name + " faints " );
                    Rivalint++;
                    if (Rivalint != Rival.belt.Count)
                    {
                        Console.WriteLine(User.name + " released " + Rival.belt[Rivalint].pokemon.name);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (User.belt[Userint].pokemon.getWeakness() == Rival.belt[Rivalint].pokemon.getType())
                {
                    Console.WriteLine(User.belt[Userint].pokemon.name + " faints ");
                    Userint++;
                    if (Userint != User.belt.Count)
                    {
                        Console.WriteLine(User.name + " released " + User.belt[Userint].pokemon.name);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
    }
}
