using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testfield3
{
     class Player
    {
        public string Name { get; set; }
        public int Number { get; set; }
    }
    class Team
    {
        Player[] player = new Player[11];
        public Player this[int index]
        {
            get
            {
                if (index >= 0 && index < player.Length)
                    return player[index];
                else
                    return null;
            }
            set
            {
                if (index >= 0 && index < player.Length)
                    player[index] = value;
            }
             
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Team inter = new Team();
            inter[5] = new Player { Name = "Ronaldo", Number = 11 };
            


            Console.WriteLine(inter[11]);

            Console.ReadLine();
        }
    }
}
