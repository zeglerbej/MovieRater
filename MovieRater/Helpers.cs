using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRater
{
    public static class Helpers
    {
        public static float GetAverage(float oldAvg, int oldNumberOfVotes, int vote)
        {
            return (oldAvg * oldNumberOfVotes + vote) / (oldNumberOfVotes + 1);
        }
    }
}
