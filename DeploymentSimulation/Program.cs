using System;
using System.Media;

namespace DeploymentSimulation
{
    class Program : Narrative
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            PlaySound();
            static void PlaySound()
            {
                var player = new SoundPlayer();
                player.SoundLocation = @"c:\Users\Samer\MSSA2021\Sounds\Themes\Intro.wav";
                player.Play();
                Console.Write("Welcome to the frontline, Warrior.");
                Console.ReadLine();
                Console.Write("Your mission is to destroy ISIS once and for all.");
                Console.ReadLine();
                Console.WriteLine("You have the unstoppable United States Air Force and Army at your command.");
                Console.ReadLine();
                Console.ResetColor();
                Console.WriteLine("Are you ready?");
                Console.WriteLine("Type [yes] if you are ready");
                Console.WriteLine("Type [no] if you need more time");
                /// Select whether you are ready or not
                MakeChoice();
                Console.ReadLine();
                player.Stop();
            }

            ///Calls troops (Airman or Soldier and gives them orders)
            Console.ResetColor();
            Console.WriteLine("Choose 4 units, a mix of Airman and Soldier.\x0A" +
                "Give them orders such as 'Ready the planes' or 'load the guns.'");
            Console.ReadLine();
            Console.WriteLine("Choose an [Airman] or [Soldier]");
            CallTroop();
            CallTroop();
            CallTroop();
            CallTroop();
            Console.ReadLine();
            Console.WriteLine();

            ///After the troops are assmbled, the story continues
            Narrative part2 = new Narrative();
            part2.MissionExecution();

            Console.WriteLine("This is it, the moment we've been waiting for.\x0A" +
                "Humvee's, roll out!");
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Humvee pennyWise = new Humvee();
            pennyWise.StartEngine();
            Console.ReadLine();
            pennyWise.Drive();
            Console.ReadLine();
            Console.WriteLine("Humvee's in place, awaitng orders.");
            pennyWise.StopEngine();
            Console.ReadLine();
            Console.ResetColor();
            Console.WriteLine("Give your soldier's the green light to open fire!\n");
            Console.ResetColor();
            Console.WriteLine("Type [open fire]");
            Console.ReadLine();
            Console.WriteLine();
            Weapons.TurretFire();
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Captain America reporting in, perimeter is secure.");
            Console.ReadLine();
            Console.ResetColor();
            Console.WriteLine("Now that your perimeter is secure, it's time to send in the demolition crew.");
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("'Strike Eagles' and 'Lancers'preparing for take-off.");
            Console.ReadLine();
            Aircraft terminator = new Aircraft();
            terminator.StartEngine();
            Console.ReadLine();
            terminator.Taxi("F-15E's and B1's");
            Console.ReadLine();
            Console.ResetColor();
            Console.WriteLine("Give your aricraft the green light to take off");
            Console.ReadLine();
            Console.WriteLine();
            terminator.TakeOff("F-15E's and B1's");
            Console.ReadLine();
            terminator.Drive();
            Console.ReadLine();

            ///Bomber's are in the air and enroute to target, story continues
            Narrative part3 = new Narrative();
            part3.Bombrun();
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("F-15E's preparing to secure air superiority.");
            Console.ReadLine();
            Console.WriteLine("Air space secured, ready to initiate bomb run.");
            Console.ReadLine();
            Console.ResetColor();
            Console.WriteLine("Type [Release]");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Bombers dive low to release payload.");
            Console.ReadLine();
            Weapons.Dive();
            Weapons.ReleaseBombs();
            Console.ReadLine();
            Weapons.BombImpact();
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Bombers circling back to confirm target is destroyed.");
            Console.ReadLine();
            Console.WriteLine("Target destruction confirmed.");
            Console.ReadLine();

            ///Mission is a success, time to head home
            Narrative part4 = new Narrative();
            part4.Return();

            ///Humvee and Aircraft begin to head home
            Console.ResetColor();
            Console.WriteLine("Tell your troops to come home");
            Console.ReadLine();
            Console.WriteLine();
            pennyWise.Drive();
            Console.ReadLine();
            terminator.Drive();
            Console.ReadLine();

            ///Aircraft get ready to land
            Console.WriteLine("'Strike Eagles' and 'Lancers' ready to descend.");
            Console.ReadLine();
            Console.WriteLine("Clear your aircraft for landing.");
            Console.ReadLine();
            Console.WriteLine();
            terminator.Land("F-15E's and B1's");
            Console.ReadLine();
            terminator.StopEngine();
            Console.ReadLine();
            Console.WriteLine();

            ///Your troops are home
            Narrative part5 = new Narrative();
            part5.MissionAccomplished();
            Console.ReadLine();


            ///Methods for Making your ready choice and calling troops
            static void MakeChoice()
            {
                string choice = (Console.ReadLine());

                if (choice == "yes")
                {
                    Console.WriteLine();
                    Narrative part1 = new Narrative(); //Make a choice for being ready or not 
                    part1.MissionBrief();
                }
                else if (choice == "no")
                {
                    Console.WriteLine("There's no time to waste, the enemy is escaping!");
                    Console.WriteLine("Type [yes] if you are ready");
                    Console.WriteLine("Type [no] if you need more time");
                    MakeChoice();
                }
                else
                {
                    Console.ResetColor();
                    Console.WriteLine("Type [yes] or [no]");
                    MakeChoice();
                }
            }

            static void CallTroop()
            {
                string troop = (Console.ReadLine());
                Console.WriteLine();


                if (troop == "Airman")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Airman officer = new Airman();
                    officer.Report();
                    Console.ResetColor();
                    officer.GiveOrder();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine();
                    officer.AcceptOrder();
                }
                else if (troop == "Soldier")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Soldier officer = new Soldier();
                    officer.Report();
                    Console.ResetColor();
                    officer.GiveOrder();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine();
                    officer.AcceptOrder();
                }
                else
                {
                    Console.ResetColor();
                    Console.WriteLine("Choose an [Airman] or [Soldier]");
                    CallTroop();
                }
            }
        }
    }
}
