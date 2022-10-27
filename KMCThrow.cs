/* ********************************************************************
 * Projct:      Dice Distribution
 * File:        KMCThrow.cs
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
 *                      - added data types to be used in KMCDiceRoller
 * *******************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceDistribution
{
    /// <summary>
    /// This class will act as a base for Throw (roll)
    /// </summary>
    internal class KMCThrow
    {
        #region data
        // NUMBER of times this total was thrown
        public int count = 0;
        // SUM of dice for THIS throw
        public int total = 0;
        // percentage of times this total was thrown over the total number of ALL throws
        public float percentage = 0;

        #endregion data

        #region properties
        #endregion properties

        #region constructor
        public KMCThrow(int newTotal, int newCount)
        {
            total = newTotal;
            count = newCount;
        }
        #endregion constructor
    }
}
