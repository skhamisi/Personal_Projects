using System;
using System.Media;

namespace DeploymentSimulation
{
    class Vehicle
    {
        public virtual void StartEngine()
        {
            Console.WriteLine($"Starting engine");

            PlaySound(@"c:\Users\Samer\MSSA2021\Sounds\Aircraft\Jet_Engine_Start.wav");
        }

        public virtual void StopEngine()
        {
            Console.WriteLine($"Shutting down");

            PlaySound(@"c:\Users\Samer\MSSA2021\Sounds\Aircraft\Jet_Engine_Shutdown.wav");

        }

        public virtual void Drive()
        {
            Console.WriteLine();
        }

        public static void PlaySound(string noise)
        {
            var player = new SoundPlayer();
            player.SoundLocation = noise;
            player.PlaySync();
        }
    }

    class Aircraft : Vehicle
    {
        public void Taxi(string typeOfAircraft)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{typeOfAircraft} head for the runway.");

            PlaySound(@"c:\Users\Samer\MSSA2021\Sounds\Aircraft\Taxi.wav");
        }

        public void TakeOff(string typeOfAircraft)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{ typeOfAircraft} taking off.");

            PlaySound(@"c:\Users\Samer\MSSA2021\Sounds\Aircraft\TakeOff.wav");
        }

        public override void Drive()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Aircraft flying to destination.");

            PlaySound(@"c:\Users\Samer\MSSA2021\Sounds\Aircraft\Flying.wav");

        }

        public void Land(string typeOfAircraft)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{typeOfAircraft} landing.");

            PlaySound(@"c:\Users\Samer\MSSA2021\Sounds\Aircraft\Landing.wav");
        }
    }

    class Humvee : Vehicle
    {
        public override void Drive()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Humvee's enroute to destination.");

            PlaySound(@"c:\Users\Samer\MSSA2021\Sounds\Humvee\Humvee_Drive.wav");
        }

        public override void StartEngine()
        {
            Console.WriteLine("Starting engine");

            PlaySound(@"c:\Users\Samer\MSSA2021\Sounds\Humvee\Humvee_Start.wav");

        }

        public override void StopEngine()
        {
            PlaySound(@"c:\Users\Samer\MSSA2021\Sounds\Humvee\Humvee_Stop.wav");
        }
    }
}
