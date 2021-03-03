using System;
using System.Media;
using System.Threading;

namespace Casino
{
    public class Game_Functions
    {
        public static void PlayRoulette()
        {
            Random randomNum = new Random();
            var r = new Random();
            string[] color = { "Red", "Black" }; /// Creates a string array containing the colors (red) and (black) ///
            int choice; /// Allows you to choose a menu option ///
            int attempts = 0; /// Sets initial attempts to zero ///
            long bet;
            long money = 1000; /// Sets the initial amount of money you start with ///

            while (money != 0) /// Starts the game if your money is not equal to zero ///
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
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
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("\nMoney:");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("$" + money);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("\tAttempts:");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(attempts);
                Console.WriteLine();

                /// Main menu, allows you to pick your type of bet ///
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\nMake a choice");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("================");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("1. Evens \n2. Odds \n3. Low's (1-18)" +
                    "\n4. High's (19-36) \n5. Red \n6. Black \n7. 1st 12 (1-12)" +
                    "\n8. 2nd 12 (13-24) \n9. 3rd 12 (25-36)");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("================");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                choice = Convert.ToInt32(Console.ReadLine());
                bool check = choice >= 1 && choice <= 9;

                /// Checks for valid input ///
                if (check == false)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\nYou did not enter a valid bet.\n");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Press [enter] to continue");
                    WaitForKey(ConsoleKey.Enter);  /// Makes sure that only the Enter key is pressed ///
                    Console.Clear();
                    continue;
                }
                else /// Continues program if a valid input is detected ///
                {
                    Console.WriteLine("\nHow much do you want to bet?\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    bet = Convert.ToInt32(Console.ReadLine());

                    /// Checks to see if you have enough money to bet ///
                    while (bet > money)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\nYou don't enough to bet that much money!\n");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Press [enter] to continue");
                        WaitForKey(ConsoleKey.Enter);

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("How much do you want to bet?");
                        Console.ForegroundColor = ConsoleColor.Green;
                        bet = Convert.ToInt32(Console.ReadLine());
                    }

                    money -= bet; /// Subtracts money from current amount after betting ///
                    int roll = randomNum.Next(0, 36); /// Rolls a random number from 0-36 ///
                    string randomColor = color[r.Next(color.Length)]; /// Picks a random color (red) or (black) ///
                    bool even = roll % 2 == 0; /// Checks to see if the roll is even ///

                    if (((choice == 1) && (even == true)) || ((choice == 2) && (even == false)) || ((choice == 5) && (randomColor == "Red")) || ((choice == 6) && (randomColor == "Black")))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("\nThe roulette rolled: " + randomColor + " " + roll);
                        Console.WriteLine("\nWINNER! $" + (bet * 2));
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Press [enter] to continue");
                        money += (bet * 2); /// Doubles the amount of money that you bet ///
                        attempts++; /// Increments the number of times you've played the current session by 1 ///
                        WaitForKey(ConsoleKey.Enter);
                    }
                    else if ((choice == 3) && ((roll > 0) && (roll < 19)))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("\nThe roulette rolled: " + randomColor + " " + roll);
                        Console.WriteLine("\nWINNER! $" + (bet * 2));
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("\nPress [enter] to continue");
                        money += (bet * 2);
                        attempts++;
                        WaitForKey(ConsoleKey.Enter);
                    }
                    else if ((choice == 4) && ((roll > 18) && (roll < 37)))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("\nThe roulette rolled: " + randomColor + " " + roll);
                        Console.WriteLine("\nWINNER! $" + (bet * 2));
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("\nPress [enter] to continue");
                        money += (bet * 2);
                        attempts++;
                        WaitForKey(ConsoleKey.Enter);
                    }
                    else if (((choice == 7) && (roll > 0 && roll < 13)) || ((choice == 8) && (roll > 12 && roll < 25)) || ((choice == 9) && (roll > 24 && roll < 37)))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("\nThe roulette rolled: " + randomColor + " " + roll);
                        Console.WriteLine("\nWINNER! $" + (bet * 2));
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("\nPress [enter] to continue");
                        money += (bet * 3);
                        attempts++;
                        WaitForKey(ConsoleKey.Enter);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\nThe roulette rolled: " + randomColor + " " + roll);
                        Console.WriteLine("\nLOSER! -$" + (bet));
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("\nPress [enter] to continue");
                        attempts++;
                        WaitForKey(ConsoleKey.Enter);

                        if (money == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\nYou're out of money.");
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Thank you for playing Deluxe Roulette! Come again!");
                            Console.WriteLine("\nPress [enter] to continue");
                            WaitForKey(ConsoleKey.Enter);
                            Console.Clear();
                            PlayRoulette(); /// Restarts the game after losing all of your money ///
                        }
                    }
                }
                Console.Clear();
            }
            try
            {
                PlayRoulette();
            }

            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
            }
        }

        /// A method that checks for a specific key press ///
        public static void WaitForKey(ConsoleKey key)
        {
            while (Console.ReadKey(true).Key != key)  /// States that while the key pressed is not equal to the specified key, do nothing ///
            { }
        }

        /// A method for playing the intro music on the main menu ///
        public static void PlaySound(string sound)
        {
            var player = new SoundPlayer();
            player.SoundLocation = sound;
            player.Play();
        }

        /// A method for playing the background music on loop while playing the game ///
        public static void PlayBackGroundMusic()
        {
            var player = new SoundPlayer();
            player.SoundLocation = @"C:\Users\Samer\MSSA2021\Sounds\Roulette\Background.wav";
            player.PlayLooping();
        }

        /// A method for creating psuedo-blinking text ///
        public static void WriteBlinkingText(string text, int delay)
        {
            bool visible = true;
            while (!Console.KeyAvailable)
            {
                Console.Write("\r" + (visible ? text : new String(' ', text.Length)));
                Thread.Sleep(delay);
                visible = !visible;
            }
        }
    }
}
