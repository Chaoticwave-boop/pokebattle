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
                  new Pokeball("ultraball", new Pokemon("Umbreon", "dark", "fighting", "Grim")),
                  new Pokeball("greatball", new Pokemon("Gengar", "ghost", "dark", "JackTheRipper")),
                  new Pokeball("pokeball",  new Pokemon("Mimikyu", "ghost", "dark", "fakePickachu")),
                  new Pokeball("greatball", new Pokemon("Ditto", "normal", "fighting", "Changeling")),
                  new Pokeball("ultraball", new Pokemon("Darkrai", "dark", "fighting", "Edgy")),
                  new Pokeball("ultraball", new Pokemon("Zoruark", "dark", "fighting", "bigWoof")),
            };


            List<Pokeball> RivalContent = new List<Pokeball>() {
                  new Pokeball("ultraball", new Pokemon("charmander", "fire", "grass", "steve")),
                  new Pokeball("greatball", new Pokemon("charmeleon", "fire", "grass", "damian")),
                  new Pokeball("pokeball",  new Pokemon("Charizard", "fire", "grass", "sith")),
                  new Pokeball("greatball", new Pokemon("torchick", "fire", "grass", "Nugget")),
                  new Pokeball("ultraball", new Pokemon("combusken", "fire", "grass", "drumstick")),
                  new Pokeball("ultraball", new Pokemon("blaziken", "fire", "grass", "rotisserie")),
            };

            Trainer Rival = new Trainer(Rivalname, RivalContent);
            Trainer User = new Trainer(UserName, UserContent);


            for (int i = 0; i < RivalContent.Count; i++)
            {
                Thread.Sleep(2000);
                Console.WriteLine(Rivalname + " released " + Rival.belt[i].pokemon.name);
                Thread.Sleep(1000);
                Console.WriteLine(UserName + " released " + User.belt[i].pokemon.name);
                Thread.Sleep(1000);
                Console.WriteLine(Rival.belt[i].pokemon.name + " !!");
                Thread.Sleep(1000);
                Console.WriteLine(User.belt[i].pokemon.name + " !!");
                Thread.Sleep(2000);
                Console.WriteLine(Rivalname + " withdrew " + Rival.belt[i].pokemon.name);
                Thread.Sleep(1000);
                Console.WriteLine(UserName + " withdrew " + User.belt[i].pokemon.name);
            }

            Console.WriteLine("Play again? yes or no");
            string Continue = Console.ReadLine();

            if (Continue == "no" + "" || Continue == "exit" + "")
            {
                break;
            }
        }

    }
}