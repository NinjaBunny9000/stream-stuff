/**
 * Written on 12-6-19 w/@AlSweigart and @Jigokuniku
 * C# version of https://github.com/asweigart/PythonStdioGames/blob/master/src/gamesbyexample/spongetext.py
 * VOD/Replay: pt1: https://www.twitch.tv/videos/518135735 pt2: https://www.twitch.tv/videos/518190637
 * Recap Blog: https://dev.to/ninjabunny9000/learning-c-w-alsweigart-live-coding-recap-3mb6
 * https://twitch.tv/ninjabunny9000
 * https://twitch.tv/alsweigart
 * https://twitch.tv/jigokuniku
 */

using System;

namespace SpongeBob
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("c# sPoNgEtExTbY aL sWeIGaRt aNd niNjAbuNnY9000. cOmeNtEr YoUr MeSsAgE:");

            // takes text input and passes into spongebob func
            string input_text = string.Empty;
            string output_text = "O K => ";
            bool use_upper = false;
            var rand =  new Random();

            Console.WriteLine("wHaT Do yoU WaNt to cOnVerT?");

            input_text = Console.ReadLine();

            // for every character in the text
            foreach (var c in input_text) {
                // check if it's an upper or lower
                if (use_upper) {
                    output_text += char.ToUpper(c);  // change it to upper
                } else {
                    output_text += char.ToLower(c);  // change it to lower
                }

                use_upper = !use_upper;  // flip the case

                // every 10 characters, randomly flip the case again
                if (rand.Next(1,10) == 1) {
                    use_upper = !use_upper;  // ;D r YoU sUrE/?
                }
            }

            Console.WriteLine(output_text);
        }
    }
}
