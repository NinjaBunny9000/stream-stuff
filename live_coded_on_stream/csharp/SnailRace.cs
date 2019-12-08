using System;
using System.Collections.Generic;
using System.Threading;

namespace SnailRace
{
    class Program
    {

        // TODO: input validation
        static void Main(string[] args)
        {
            // part 0) define vars
            const int MAX_NUM_SNAILS = 8;  // TODO
            const int MAX_NAME_LENGTH = 12; // TODO
            const int FINISH_LINE = 60;
            int num_snails = 0;
            var snail_names = new List<string>();
            var snail_progress = new Dictionary<string, int>();
            var rand =  new Random();
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // part 1) ask how many snails
            // TODO: validate for bad input
            Console.WriteLine("How many snails are racing today? (MAX 8?");
            num_snails = int.Parse(Console.ReadLine());

            // part 2) ask for the snail's names
            // TODO: implement character limit
            for(int i = 0; i < num_snails; i++) {
                Console.WriteLine($"What do you want to name snail #{i}?");
                snail_names.Add(Console.ReadLine());
                snail_progress.Add(snail_names[i], 0);
            }

            // part 3) print out the starting line setup
            Console.Clear();
            PrintStartingLine(FINISH_LINE);
            Thread.Sleep(1500);  // pause before starting the race

            bool racing = true;  // TODO make it a do-while later too

            // part 4) big while loop that does the race
            while (racing) {
                // pause and clear the screen between each frame
                Thread.Sleep(500);
                Console.Clear();

                // progress a random snail
                string moving_snail = snail_names[rand.Next(num_snails)];
                snail_progress[moving_snail] += 1;

                // check if snails have finished
                if (snail_progress[moving_snail] >= FINISH_LINE) {
                    Console.WriteLine($"{moving_snail} has won!!");
                    racing = false;  // exit the program
                }

                // render the snails to the console
                PrintStartingLine(FINISH_LINE);
                foreach (var snail in snail_names) {
                    PrintSnail(snail, snail_progress[snail]);
                }
            }
        }

        // TODO: maths so starting line moves to accommodate name length
        static void PrintStartingLine(int length) {
            // print starting line 60-spaces from the finish line
            var spaces = new string (' ', length);
            Console.WriteLine($"START{spaces}FINISH");
            Console.WriteLine($"    |{spaces}|");
        }

        // TODO: align the snail's names (better)
        static void PrintSnail(string name, int pos) {
            // print spaces and then the snail's name
            var offset = new string (' ', 5);
            var spaces = new string (' ', pos);
            Console.WriteLine("   " + spaces + name);
            // print number of dots of position and the snail
            var dots = new string ('.', pos);
            Console.WriteLine("    " + dots + "@v");
        }
    }
}
