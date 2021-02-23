using System;
using System.Media;

namespace DeploymentSimulation
{
    class Narrative
    {
        public void MissionBrief()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Mission Brief");
            Console.WriteLine("=============");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("We've gotten a report that the terrorist group known as ISIS,\x0A" +
                "is making their last stand on an island West of here.");
            Console.ReadLine();
            Console.WriteLine("You will lead a joint operation precision strike, dubbed 'Red Armageddon'.");
            Console.ReadLine();
            Console.WriteLine("The Air Force has two bombers ready for use: The F-15E 'Strike Eagle' and the B1 'Lancer',\x0A" +
                "both are ready to give you air superiority.");
            Console.ReadLine();
            Console.WriteLine("The Army will secure the perimeter around the island,\x0A" +
                "they will ensure no one enters or leaves.");
            Console.ReadLine();
            Console.WriteLine("When your forces are in place, your bombers can deliver their payload.");
            Console.ReadLine();
            Console.WriteLine("Gather your troops and prepare to put warheads on foreheads!!");
        }

        public void MissionExecution()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Mission Execution");
            Console.WriteLine("=================");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Alright, now that your troops are assembled, it's time to move out.");
            Console.ReadLine();
            Console.WriteLine("The Humvee's will roll out first, they will lockdown the perimeter around the island.");
            Console.ReadLine();
            Console.WriteLine("Once they have the island locked down, the bombers will deploy to the skies.");
            Console.ReadLine();
        }

        public void Bombrun()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Bomb Run");
            Console.WriteLine("========");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Your bomber's have reached their destination, it's time to light up the island!");
        }

        public void Return()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Return Home");
            Console.WriteLine("===========");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Your bomber's have carried out their mission with deadly precision.\x0A" +
                "It's time to call your troops home.");
            Console.ReadLine();
        }

        public void MissionAccomplished()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Mission Accomplished");
            Console.WriteLine("====================");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Congratulations, Warrior.\x0A" +
                "Your mission is a success and ISIS is no more.");
            Console.ReadLine();
            Console.WriteLine("Take pride in the bravery of your men, their actions today have saved countless lives.");
            Console.ReadLine();
            Console.WriteLine("Although we have won this battle, the war against evil rages on.\x0A" +
                "Stay alert.");
            Console.ReadLine();
            Console.WriteLine("For now, rest, you have earned it.\n\n");
            Console.ReadLine();
            Console.WriteLine("THE END");
            PlaySound(@"c:\Users\Samer\MSSA2021\Sounds\Themes\Outro.wav");
        }

        public static void PlaySound(string noise)
        {
            var player = new SoundPlayer();
            player.SoundLocation = noise;
            player.Play();
        }
    }
}
