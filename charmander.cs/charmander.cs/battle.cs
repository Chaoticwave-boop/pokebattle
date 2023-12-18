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
            
            Console.WriteLine(User.getName() + " released " + User.getBelt()[Userint].getPokemonInBall().getName());
            Console.WriteLine(Rival.getName() + " released " + Rival.getBelt()[Rivalint].getPokemonInBall().getName());

            while (true)
            {
                Arena.increaseBattleCount();
                Thread.Sleep(2000);
                ///winstate total game
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
                //each battle
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Pokemon on the field:");
                Console.WriteLine($"{User.getBelt()[Userint].getPokemonInBall().getName()}");
                Console.WriteLine($"{Rival.getBelt()[Rivalint].getPokemonInBall().getName()}");
                Console.WriteLine("-----------------------------");

                if (User.getBelt()[Userint].getPokemonInBall().getType() == Rival.getBelt()[Rivalint].getPokemonInBall().getType())
                {
                    Console.WriteLine("its a draw");
                    Console.WriteLine($"{Rival.getName()} {Rival.getBelt()[Rivalint].CloseBall()}");
                    Console.WriteLine($"{User.getName()} {User.getBelt()[Userint].CloseBall()}");
                    Rivalint++;
                    Userint++;
                }
                else if (User.getBelt()[Userint].getPokemonInBall().getType() == Rival.getBelt()[Rivalint].getPokemonInBall().getWeakness())
                {
                    Console.WriteLine( $"{Rival.getName()}'s {Rival.getBelt()[Rivalint].getPokemonInBall().getName()} faints" );
                    Console.WriteLine($"{Rival.getName()} {Rival.getBelt()[Rivalint].CloseBall()}");
                    Rivalint++;
                    if (Rivalint != Rival.getBelt().Count)
                    {
                        Console.WriteLine($"{Rival.getName()} {Rival.getBelt()[Rivalint].OpenBall()}");
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (User.getBelt()[Userint].getPokemonInBall().getWeakness() == Rival.getBelt()[Rivalint].getPokemonInBall().getType())
                {
                    Console.WriteLine($"{User.getName()}'s {User.getBelt()[Userint].getPokemonInBall().getName()} faints ");
                    Console.WriteLine($"{User.getName()} {User.getBelt()[Userint].CloseBall()}");
                    Userint++;
                    if (Userint != User.getBelt().Count)
                    {
                        Console.WriteLine($"{User.getName()} {User.getBelt()[Userint].OpenBall()}");
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
