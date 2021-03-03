using System;
using System.Media;
namespace Casino
{
    public class Roulette : Game_Functions
    {

        static void Main(string[] args)
        {
            StartMenu();
            PlayRoulette();
        }

        public static void StartMenu()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            PlaySound(@"C:\Users\Samer\MSSA2021\Sounds\Roulette\Intro.wav");
            Console.WriteLine("\n*********************************");
            Console.WriteLine("*********************************");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("$ $ $ $ ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(" Deluxe Roulette");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" $ $ $ $\n");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("*********************************");
            Console.WriteLine("*********************************\n");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            WriteBlinkingText("Press [Enter] to Start", 700);
            WaitForKey(ConsoleKey.Enter);
            Console.Clear();
            /// Starts playing the background music on loop ///
            PlayBackGroundMusic();
        }
    }
}
