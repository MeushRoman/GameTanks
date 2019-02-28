using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleGameTanks.ConsoleGame
{
    class GameProc
    {
        public GameProc()
        {
            StartGame();
        }
        public void StartGame()
        {
            GameTank t = new GameTank();

            int count = 0;
            Thread.Sleep(2000);
            for (int i = 0, j = 5; i < 5; i++, j++)
            {                
                Console.Clear();
                Console.WriteLine("Тун-ту-ру-руууун\nНачинается битва №{0}\n\n",i+1);
                Thread.Sleep(1000);

                if (t.Tanks[i] * t.Tanks[j] == true)
                {                    
                    Console.WriteLine("Победил T-34");       
                    Console.WriteLine("\n{0}\n\n{1}", t.Tanks[i].GetInfo(), t.Tanks[j].GetInfo());
                    Console.WriteLine("\n----------------------------------\n");
                    count++;
                }
                else
                {
                    Console.WriteLine("Победил Pantera");
                    Console.WriteLine("\n{0}\n\n{1}", t.Tanks[i].GetInfo(), t.Tanks[j].GetInfo());
                    Console.WriteLine("\n----------------------------------\n");
                }
                Thread.Sleep(4000);
            }
            Console.Clear();
            Console.WriteLine("Победителями становятся: {0}\n", (count>3)?"T-34": "Pantery");
            Console.WriteLine("T-34 одержали {0} победы\nPantery одержали {1} победы", count, 5-count);
        }


    }
}
