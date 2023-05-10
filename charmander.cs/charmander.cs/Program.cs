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

            pokemon charmander = new pokemon("charmander", "grass", "fire", Pokename);

            Console.WriteLine("pokename:" + charmander.pokename);
            Console.WriteLine(charmander.name);
            Console.WriteLine(charmander.strenght);
            Console.WriteLine(charmander.weakness);

            Console.WriteLine("---------");

            Console.WriteLine(bulbasaur.name);
            Console.WriteLine(bulbasaur.strenght);
            Console.WriteLine(bulbasaur.weakness);


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine((i + 1) + "--" + "CHARMANDER!");
            };


            if (Pokename == "exit") {
                break;
            }
        }

       

    }
}