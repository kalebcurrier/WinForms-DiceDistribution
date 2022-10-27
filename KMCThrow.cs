using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceDistribution
{
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
