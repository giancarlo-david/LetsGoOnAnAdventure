using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsGoOnAnAdventure
{
    class Companion
    {
        private bool? Join { get; set; }
        private string[] Sound;
        private int RegularOdd { get; set; }
        private int FinalOdd { get; set; }

        Random rng = new Random();

        // Default Constructor
        public Companion()
        {
        }

        // Parameterized Constructor
        public Companion(bool? join, string sound1, string sound2, string sound3, int regularOdds, int finalOdds)
        {
            Sound = new string[3];

            Join = join;
            Sound[0] = sound1;
            Sound[1] = sound2;
            Sound[2] = sound3;
            RegularOdd = regularOdds;
            FinalOdd = finalOdds;
        }

        // Complain function to play randomly selected sound when companion complains
        public string Complain()
        {
            string saying = null;

            if (Join == true)
            {
                int chosenSound = rng.Next(3);
                saying = Sound[chosenSound];
            }

            else
            {
                saying = "If only they were here...";
            }

            return saying;
        }

        // Check to see if companion will go on regular events
        public bool? ToGo(int guess)
        {
            int numToGuess = rng.Next((RegularOdd + 1) + 1);

            // Checks to see if guess is within the range
            if (guess >= 1 && guess <= RegularOdd)
            {
                if (guess == numToGuess)
                {
                    Join = true;
                }

                else
                {
                    Join = false;
                }
            }

            else
            {
                Join = null;
            }

            return Join;
        }

        public bool? FinalsToGo(int guess)
        {
            int numToGuess = rng.Next((FinalOdd + 1) + 1);

            // Checks to see if guess is within the range
            if (guess >= 1 && guess <= FinalOdd)
            {
                if (guess == numToGuess)
                {
                    Join = true;
                }

                else
                {
                    Join = false;
                }
            }

            else
            {
                Join = null;
            }

            return Join;
        }

        public bool? ResetGo()
        {
            Join = null;

            return Join;
        }
    }
    
}
