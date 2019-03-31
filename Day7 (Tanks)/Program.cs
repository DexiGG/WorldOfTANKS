using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLib.WorldOfTanks;

namespace Day7__Tanks_
{
    class Program
    {
        static void Main(string[] args)
        {
            const int COUNT_OF_TANKS = 5;
            const int END_RANGE = 100;
            const string FIRST_KIND_OF_TANK = "T-34";
            const string SECOND_KIND_OF_TANK = "Pantera";
            int weapon;
            int armourLevel;
            int manoeuvrability;

            Random rnd = new Random();
            Tank[] t34 = new Tank[COUNT_OF_TANKS];
            Tank[] pantera = new Tank[COUNT_OF_TANKS];

            for (int i = 0; i < COUNT_OF_TANKS; i++)
            {
                weapon = rnd.Next(END_RANGE);
                armourLevel = rnd.Next(END_RANGE);
                manoeuvrability = rnd.Next(END_RANGE);
                t34[i] = new Tank(FIRST_KIND_OF_TANK, weapon, armourLevel, manoeuvrability);

                weapon = rnd.Next(END_RANGE);
                armourLevel = rnd.Next(END_RANGE);
                manoeuvrability = rnd.Next(END_RANGE);
                pantera[i] = new Tank(SECOND_KIND_OF_TANK, weapon, armourLevel, manoeuvrability);
            }

            Battle(t34, pantera, COUNT_OF_TANKS);
        }
        static void Battle(Tank[] t34, Tank[] pantera, int COUNT_OF_TANKS)
        {
            for (int i = 0; i < COUNT_OF_TANKS; i++)
            {
                Console.WriteLine("Пара №{0}", i + 1);
                Tank.Show(t34[i], pantera[i]);
                try
                {
                    if (t34[i] ^ pantera[i]) Console.WriteLine("Победитель сражения: T-34\n");
                    else Console.WriteLine("Победитель сражения: Pantera\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
