// See https://aka.ms/new-console-template for more information
using poke;

class main
{
    static void Main(string[] args)
    {

        bool gamestart = true;

        while (gamestart)
        {

            pokemon bulbasaur = new pokemon("bulbasaur", "grass", "fire", "");

            Console.WriteLine("enter your charmanders name");
            string Pokename = Console.ReadLine();

            pokemon charmander = new pokemon("charmander", "fire", "water", Pokename);

            Console.WriteLine("pokename: " + charmander.pokename);
            Console.WriteLine("name: " + charmander.name);
            Console.WriteLine("type: " + charmander.type);
            Console.WriteLine("weakness: " + charmander.weakness);

            Console.WriteLine("---------");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine((i + 1) + "--" + charmander.pokename);
            };


            if (Pokename == "exit") {
                break;
            }
        }

       

    }
}