using System;

namespace DeploymentSimulation
{
    class Weapons : Vehicle
    {
        public static void ReleaseBombs()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"payload released, 5 seconds to impact!");

            PlaySound(@"c:\Users\Samer\MSSA2021\Sounds\Weapons\Bomb_Release.wav");
        }

        public static void BombImpact()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("5....");
            Console.ReadLine();
            Console.WriteLine("4....");
            Console.ReadLine();
            Console.WriteLine("3....");
            Console.ReadLine();
            Console.WriteLine("2....");
            Console.ReadLine();
            Console.WriteLine("1....");
            Console.ReadLine();
            Console.WriteLine("Target contact!");

            PlaySound(@"c:\Users\Samer\MSSA2021\Sounds\Weapons\Bomb_Impact.wav");
        }

        public static void TurretFire()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Roger, locking turrets onto targets.");
            Console.ReadLine();
            Console.WriteLine("Firing!");

            PlaySound(@"c:\Users\Samer\MSSA2021\Sounds\Weapons\Turret.wav");
        }

        public static void Dive()
        {
            PlaySound(@"c:\Users\Samer\MSSA2021\Sounds\Weapons\Dive.wav");
        }
    }
}
