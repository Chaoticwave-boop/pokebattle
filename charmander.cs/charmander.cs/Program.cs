// See https://aka.ms/new-console-template for more information
using poke;

class main
{
    static void Main(string[] args)
    {

        bool gamestart = true;

        while (gamestart)
        {
            Console.WriteLine("enter your name");
            string UserName = Console.ReadLine();

            Console.WriteLine("enter your rivals name");
            string Rivalname = Console.ReadLine();

            Trainer Rival = new Trainer(Rivalname);
            Trainer User = new Trainer(UserName);

            // try / catch -> argumentexception
            try
            {
                User.AddPokemon("pokeball", new Bulbasaur("Bulbasaur"));
                User.AddPokemon("pokeball", new Charmander("Charmander"));
                User.AddPokemon("pokeball", new Squirtle("Squirtle"));
                User.AddPokemon("pokeball", new Charmander("Charmander"));
                User.AddPokemon("pokeball", new Squirtle("Squirtle"));


                Rival.AddPokemon("pokeball", new Bulbasaur("Bulbasaur"));
                Rival.AddPokemon("pokeball", new Charmander("Charmander"));
                Rival.AddPokemon("pokeball", new Squirtle("Squirtle"));
                Rival.AddPokemon("pokeball", new Charmander("Bulbasaur"));
                Rival.AddPokemon("pokeball", new Bulbasaur("Bulbasaur"));
            }
            catch (Exception e)
            {
                throw new ArgumentException("there is error!");
            }


            Arena arena = new Arena(Rival, User);

            arena.test();

            Console.WriteLine("Play again? yes or no");
            string Continue = Console.ReadLine();

            if (Continue == "no" + "" || Continue == "exit" + "")
            {
                Console.WriteLine("Battles battled: " + Arena.getBattleCount());
                Console.WriteLine("Rounds battled : " + Arena.getRoundCount());
                break;
            }
            else
            {

                Console.WriteLine("Battles battled: " + Arena.getBattleCount());
                Console.WriteLine("Rounds battled : " + Arena.getRoundCount());
            }
        }

    }
}