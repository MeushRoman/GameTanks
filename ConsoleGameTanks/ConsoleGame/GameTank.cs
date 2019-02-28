using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLib.WordOfTanks;

namespace ConsoleGameTanks.ConsoleGame
{
    public class GameTank 
    {
        public GameTank()
        {
            Tanks = new List<Tank>();
            Create();
        }
        public static Random rnd = new Random();

        private Tank CreateTank(string name)
        {
            return new Tank(name, rnd.Next(0, 100), rnd.Next(0, 100), rnd.Next(0, 100));            
        }

        public List<Tank> Tanks { get; set; }

        public void Create()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i < 5) Tanks.Add(CreateTank("t-34")); else Tanks.Add(CreateTank("Pantera"));
            }
        }
    }
}
