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
using System.Collections.Generic;
using System.Linq;

namespace DiceDistribution
{
    internal class KMCDiceRoller
    {
        #region data
        Random random = new Random();
        KMCThrow[] throws;
        //https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-7.0
        // found how to use list here

        List<KMCThrow> stats;
        #endregion data

        #region properties
        private int numberOfThrows = 0;
        private int countOfThrows = 0;
        private float AverageThrow = 0;
        private int SumOfThrows = 0;
        private int MinimumThrow = 0;
        private int MaximumThrow = 0;
        #endregion properties

        #region constructor
        public KMCDiceRoller(int newNumberOfThrows)
        {
            numberOfThrows = newNumberOfThrows;
            throws = new KMCThrow[newNumberOfThrows];
            stats = new List<KMCThrow>();
        }

        #endregion constructor

        #region methods


        /// <summary>
        /// This method throws the dice, calculates the stats, and displays the stats.
        /// </summary>
        /// <param name="numberOfDice"></param>
        /// <returns></returns>
        public String[] Throw(int numberOfDice)
        {
            countOfThrows = 0;

            // throw dice per specified number of throws user enters
            for (int i = 0; i < numberOfThrows; i++)
            {
                // add a throw to the list
                ThrowDice(numberOfDice);
            }
            CalculateThrows();
            return DisplayThrows();
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
            return random.Next(1, 7);
        }

        /// <summary>
        /// This method returns a total value based on the sum
        /// and calls update throws
        /// </summary>
        private void ThrowDice(int numberOfDice)
        {
            int sumOfDice = 0;

            // get sum of dice thrown
            for (int i = 0; i < numberOfDice; i++)
            {
                sumOfDice += ThrowDie();

            }
            // add the throw to the list of throws
            AddThrow(sumOfDice);
        }

        private void AddThrow(int sumOfDice)
        {
            throws[countOfThrows++] = new KMCThrow(sumOfDice, 1);
        }
        private void CalculateThrows()
        {
            // populate stats List from throws array 
            GetStats();

            // add pecentages to stats
            CalculatePercentages();

            
            // sort stats
            // https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.sort?view=net-7.0
            // used this to figure out how to sort a list with a delegate
            stats.Sort(delegate (KMCThrow a, KMCThrow b)
            {
                if (a.total > b.total)
                {
                    return 1;
                }
                else if (a.total == b.total)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }

            });
            // calculate average roll/throw
            AverageThrow = (float)SumOfThrows / numberOfThrows;

            // calc
            MinimumThrow = stats.First().total;

            MaximumThrow = stats.Last().total;
        }

        private void CalculatePercentages()
        {
            int totalCountOfAllThrows = 0;

            // get total count
            foreach (KMCThrow stat in stats)
            {
                // total count of all throws
                totalCountOfAllThrows += stat.count;
            }

            // get percentage for each stat
            foreach (KMCThrow stat in stats)
            {
                stat.percentage = (float)stat.count / totalCountOfAllThrows * 100;
            }

        }

        /// <summary>
        /// This method gets the counts for each total in throws (rolls)
        /// </summary>
        /// <returns>stats as an array of KMCThrow Objects</returns>
        private void GetStats()
        {
            // loop through all throws to count them
            for (int throwIndex = 0; throwIndex < throws.Length; throwIndex++)
            {
                // calculate the sum of all throws
                SumOfThrows += throws[throwIndex].total;

                // determine if we find a matching throw total in stats[]
                bool foundStat = false;

                // loop through all stats to find a matching throw total
                foreach (KMCThrow stat in stats)
                {
                    // if found, increment the count for this.stat and record that it was found
                    if (stat.total == throws[throwIndex].total)
                    {
                        foundStat = true;
                        stat.count++;
                        // exits for loop if found to save a few passes
                        continue;
                    }
                }
                // if no matching stat was found for this throw, add a new one to the 
                if (!foundStat)
                {
                    stats.Add(new KMCThrow(throws[throwIndex].total, 1));
                }
            }
            
        }

        private String[] DisplayThrows()
        {
            String[] rows = new String[stats.Count + 4];
            int rowCount = 0;
            foreach (KMCThrow stat in stats)
            {
                rows[rowCount++] = String.Format("Roll {0} - {1} Times - {2:0.00}%", stat.total, stat.count, stat.percentage);
            }
            rows[rowCount++] = String.Format("Average Throw: {0:0.00}", AverageThrow);
            rows[rowCount++] = String.Format("Sum of all Throws: {0}", SumOfThrows);
            rows[rowCount++] = String.Format("Minimum Throw: {0}", MinimumThrow);
            rows[rowCount++] = String.Format("Maximum Throw: {0}", MaximumThrow);
            return rows;
        }

        #endregion private methods
    }
}
