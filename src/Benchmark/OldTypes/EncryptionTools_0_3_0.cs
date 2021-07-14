using System;

namespace Benchmark.OldTypes
{
    static class EncryptionTools_0_3_0
    {
        /// An old class, just used for comparing the older versions of the EncTypes

        #region Methods

        // The Random class for getting the random numbers
        static private Random random = new Random();

        // Returns a random float between 1 and 10
        public static float RandomNumberFloat()
        {
            return (float)(random.NextDouble() * 10);
        }

        // Returns a random double between 1 and 10
        public static double RandomNumberDouble()
        {
            return (random.NextDouble() * 10);
        }

        // Returns a random decimal between 1 and 10
        public static decimal RandomNumberDecimal()
        {
            return (decimal)(random.NextDouble() * 10);
        }

        #endregion
    }
}
