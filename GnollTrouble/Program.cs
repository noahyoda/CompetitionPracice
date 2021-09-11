using System;
using System.Collections.Generic;

namespace GnollTrouble
{
    class Program
    {
        static void Main(string[] args)
        {
            string monsterStats = Console.ReadLine();
            string spawns = Console.ReadLine();
            string[] stats = monsterStats.Split(" ");
            string[] spawnChance = spawns.Split(" ");
            //this is the array that will be printed
            int[] effectiveChance = new int[int.Parse(stats[5])];



        }
    }
}
