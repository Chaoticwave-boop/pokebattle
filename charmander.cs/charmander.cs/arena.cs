using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using poke;
namespace poke
{
    public class Arena
    {
        public static int rounds;

        public Trainer User;
        public Trainer Rival;

        public Arena(Trainer User, Trainer Rival) 
        { 
            this.User = User;
            this.Rival = Rival;     
        }
      

        public void test()
        {

            Console.WriteLine(User.belt.Count);
            Console.WriteLine(Rival.belt.Count);


            Random rand = new Random();
            User.belt = User.belt.OrderBy(_ => rand.Next()).ToList();
            Rival.belt = Rival.belt.OrderBy(_ => rand.Next()).ToList();

            Battle battle = new Battle(Rival, User);
            battle.battle_results();
        }
    }
}



