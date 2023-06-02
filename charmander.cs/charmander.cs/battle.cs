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
            Console.WriteLine(Rival.getName() + " released " + Rival.getBelt()[Rivalint].getPokemonInBall().getName());
            Console.WriteLine(User.getName() + " released " + User.getBelt()[Userint].getPokemonInBall().getName());

            while (true)
            { 
                Thread.Sleep(2000);
                if (Userint >= User.getBelt().Count && Rivalint >= Rival.getBelt().Count)
                {
                    Console.WriteLine("everybody wins :D");
                    break;
                }
                else if (Userint >= User.getBelt().Count)
                {
                    Console.WriteLine(Rival.getName() + " won ");
                    break;
                }
                else if (Rivalint >= Rival.getBelt().Count)
                {
                    Console.WriteLine(User.getName() + " won ");
                    break;
                }

                if (User.getBelt()[Userint].getPokemonInBall().getType() == Rival.getBelt()[Rivalint].getPokemonInBall().getType())
                {
                    Console.WriteLine("its a draw");
                    Rivalint++;
                    Userint++;
                }
                else if (User.getBelt()[Userint].getPokemonInBall().getType() == Rival.getBelt()[Rivalint].getPokemonInBall().getWeakness())
                {
                    Console.WriteLine(Rival.getBelt()[Rivalint].getPokemonInBall().getName() + " faints " );
                    Rivalint++;
                    if (Rivalint != Rival.getBelt().Count)
                    {
                        Console.WriteLine(User.getName() + " released " + Rival.getBelt()[Rivalint].getPokemonInBall().getName());
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (User.getBelt()[Userint].getPokemonInBall().getWeakness() == Rival.getBelt()[Rivalint].getPokemonInBall().getType())
                {
                    Console.WriteLine(User.getBelt()[Userint].getPokemonInBall().getName() + " faints ");
                    Userint++;
                    if (Userint != User.getBelt().Count)
                    {
                        Console.WriteLine(User.getName() + " released " + User.getBelt()[Userint].getPokemonInBall().getName());
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
