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

            List<Pokeball> UserContent = new List<Pokeball>() {
                  new Pokeball("ultraball", new Charmander("Charmander")),
                  new Pokeball("ultraball", new Squirtle("Squirtle")),
                  new Pokeball("ultraball", new Bulbasaur("Bulbasaur")),
                  new Pokeball("ultraball", new Charmander("Charmander")),
                  new Pokeball("ultraball", new Charmander("Charmander")),
                  new Pokeball("ultraball", new Squirtle("Squirtle")),
            };


            List<Pokeball> RivalContent = new List<Pokeball>() {
                  new Pokeball("ultraball", new Bulbasaur("Bulbasaur")),
                  new Pokeball("ultraball", new Squirtle("Squirtle")),
                  new Pokeball("ultraball", new Bulbasaur("Bulbasaur")),
                  new Pokeball("ultraball", new Charmander("Charmander")),
                  new Pokeball("ultraball", new Bulbasaur("Bulbasaur")),
                  new Pokeball("ultraball", new Squirtle("Squirtle")),
            };

            Trainer Rival = new Trainer(Rivalname, RivalContent);
            Trainer User = new Trainer(UserName, UserContent);

            Arena arena = new Arena(Rival, User);

            arena.test();

            //for (int i = 0; i < RivalContent.Count; i++)
            //{
               // Thread.Sleep(2000);
               // Console.WriteLine(Rivalname + " released " + Rival.belt[i].pokemon.name);
               // Thread.Sleep(1000);
               // Console.WriteLine(UserName + " released " + User.belt[i].pokemon.name);
               // Thread.Sleep(1000);
              //  Console.WriteLine(Rival.belt[i].pokemon.name + " !!");
               // Thread.Sleep(1000);
               // Console.WriteLine(User.belt[i].pokemon.name + " !!");
               // Thread.Sleep(2000);
               // Console.WriteLine(Rivalname + " withdrew " + Rival.belt[i].pokemon.name);
               //// Thread.Sleep(1000);
              //  Console.WriteLine(UserName + " withdrew " + User.belt[i].pokemon.name);
           // }

            Console.WriteLine("Play again? yes or no");
            string Continue = Console.ReadLine();

            if (Continue == "no" + "" || Continue == "exit" + "")
            {
                break;
            }
            else
            {
                Arena.rounds++;
                Console.WriteLine("Rounds battled : " + Arena.rounds);
            }
        }

    }
}