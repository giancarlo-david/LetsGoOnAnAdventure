using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsGoOnAnAdventure
{
    class Companion
    {
        bool? Join { get; set; }
        string[] Sound { get; set; }
        int RegularOdd { get; set; }
        int FinalOdd { get; set; }

        Random rng = new Random();

        // Default Constructor
        public Companion()
        {
        }

        // Parameterized Constructor
        public Companion(bool join, string sound1, string sound2, string sound3, int regularOdds, int finalOdds)
        {
            this.Join = join;
            this.Sound[0] = sound1;
            this.Sound[1] = sound2;
            this.Sound[2] = sound3;
            this.RegularOdd = regularOdds;
            this.FinalOdd = finalOdds;
        }

        // Complain function to play randomly selected sound when companion complains
        public string Complain()
        {
            string saying = null;

            if (this.Join == true)
            {
                int chosenSound = rng.Next(3);
                saying = this.Sound[chosenSound];
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
            int numToGuess = rng.Next((this.RegularOdd + 1) + 1);

            // Checks to see if guess is within the range
            if (guess >= 1 && guess <= this.RegularOdd)
            {
                if (guess == numToGuess)
                {
                    this.Join = true;
                }

                else
                {
                    this.Join = false;
                }
            }

            else
            {
                this.Join = null;
            }

            return this.Join;
        }

        public bool? FinalsToGo(int guess)
        {
            int numToGuess = rng.Next((this.FinalOdd + 1) + 1);

            // Checks to see if guess is within the range
            if (guess >= 1 && guess <= this.FinalOdd)
            {
                if (guess == numToGuess)
                {
                    this.Join = true;
                }

                else
                {
                    this.Join = false;
                }
            }

            else
            {
                this.Join = null;
            }

            return this.Join;
        }

        public bool? ResetGo()
        {
            this.Join = null;

            return this.Join;
        }
    }
    
}
