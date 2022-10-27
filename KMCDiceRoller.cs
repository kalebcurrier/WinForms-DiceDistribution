/* ********************************************************************
 * Projct:      Dice Distribution
 * File:        KMCDiceRoller.cs
 * Language:    C#
 * 
 * Desription:  This will roll dice or a singular die and return values
 *              to be displayed in a text box
 *              
 * College:     Husson University
 * Course:      IT 325
 * 
 * Edit History:
 * Ver   Who Date       Notes
 * ----- --- ---------- -----------------------------------------------
 * 0.1   KMC 10/26/2022 - initial writing
 *                      - throws = rolls
 * *******************************************************************/
using System;
using System.Runtime.InteropServices;

namespace DiceDistribution
{
    internal class KMCDiceRoller
    {
        #region data
        Random random = new Random();
        KMCThrow[] throws;
        #endregion data

        #region properties
        private float AverageThrow = 0;
        private int SumOfThrows = 0;
        private int MinimumThrow = 0;
        private int MaximumThrow = 0;
        private int CumulativeNumber = 0;
        private float CumulativePercentage = 0;             // cumulative percentage of dice throws

        #endregion properties

        #region constructor
        public KMCDiceRoller()
        {
            throws = new KMCThrow[0];
        }

        #endregion constructor

        #region methods



        public String Throw()
        {
            return "";
            // clear array each time at end
        }
        #endregion methods
        #region private methods
        /// <summary>
        /// This method returns a random number based on the min/max params
        /// </summary>
        private int ThrowDie()
        {
            // returns a random number 1-6, from a single "die"
            return random.Next(1, 6);
        }

        /// <summary>
        /// This method returns a total value based on the sum
        /// and calls update throws
        /// </summary>
        private void ThrowDice(int numberOfDice)
        {
            int sumOfDice = 0;

            for (int i = 0; i < numberOfDice; i++)
            {
                sumOfDice += ThrowDie();

            }

        }

        private void AddThrow(int sumOfDice)
        {
            throws[throws.Length] = new KMCThrow(sumOfDice, 1);
        }
        private void CalculateThrows()
        {
            KMCThrow[] stats = new KMCThrow[0];

            // loop through all throws to count them
            for (int throwIndex = 0; throwIndex < throws.Length; throwIndex++)
            {
                // determine if we find a matching throw total in stats[]
                bool foundStat = false;

                // loop through all stats to find a matching throw total
                for (int statIndex = 0; statIndex < stats.Length; throwIndex++)
                {
                    // if found, increment the count for this.stat and record that it was found
                    if (stats[statIndex].total == throws[throwIndex].total)
                    {
                        foundStat = true;
                        stats[statIndex].count++;
                        // exits for loop if found to save a few passes
                        continue;
                    }
                }
                // if no matching stat was found for this throw, add a new one to the 
                if (!foundStat)
                {
                    stats[stats.Length] = new KMCThrow(throws[throwIndex].total, 1);
                }
            }
        }

        private String DisplayThrows()
        {
            return "";
        }

        #endregion private methods
    }
}
