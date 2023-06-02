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
        private List<Pokeball> UserBelt;
        private List<Pokeball> RivalBelt;

        public Arena(Trainer User, Trainer Rival) 
        { 
            this.User = User;
            this.Rival = Rival;     
        }
      

        public void test()
        {

            Console.WriteLine(User.getBelt().Count);
            Console.WriteLine(Rival.getBelt().Count);

            UserBelt = User.getBelt();
            RivalBelt = Rival.getBelt();

            Random rand = new Random();
            UserBelt = User.getBelt().OrderBy(_ => rand.Next()).ToList();
            RivalBelt = Rival.getBelt().OrderBy(_ => rand.Next()).ToList();

            Battle battle = new Battle(Rival, User);
            battle.battle_results();
        }
    }
}



