using System;

namespace SpongeBob
{
    class Program
    {
        /// <summary>convert normal text to spongebob text</summary>
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

            // Console.WriteLine("You entered {0}", input_text); // DEBUG

            // for every character in the text
            foreach (var c in input_text)
            {
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

            // print to console
            Console.WriteLine(output_text);
            // Clipboard.SetText(output_text); // PROBLEM FOR LATER ME
        }
    }
}
