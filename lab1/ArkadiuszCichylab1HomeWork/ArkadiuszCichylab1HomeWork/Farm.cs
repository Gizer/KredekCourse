namespace ArkadiuszCichylab1HomeWork
{
    /// <summary>
    /// Static class that manages all farms and their properties
    /// </summary>
    public static class Farm
    {
        private const int woodCost = 40;        // How much wood farm cost
        private const int moneyCost = 200;      // How much money farm cost
        private const int baseProduction = 2;   // How much one mine products
        private static int farmsCount = 0;      // How many farms there are

        /// <summary>
        /// Checking if player has enough resources to build farm
        /// </summary>
        /// <param name="playersWood">Ammount of player's wood</param>
        /// <param name="playersMoney">Ammount of player's money</param>
        /// <returns>True if building is avalible</returns>
        public static bool ResourceCheck(ref int playersWood, ref int playersMoney)
        {
            if (playersWood >= woodCost && playersMoney >= moneyCost)
            {
                playersWood -= woodCost;
                playersMoney -= moneyCost;
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Increase number of farms due to player's action
        /// </summary>
        public static void Build()
        {
            ++farmsCount;
        }

        /// <summary>
        /// Decrase number of farms due to player's actions or events
        /// </summary>
        public static void Destroy()
        {
            --farmsCount;
        }

        /// <summary>
        /// Returns total cost for farm
        /// </summary>
        /// <returns>Total cost for farm</returns>
        public static string GetCost()
        {
            // Building string for output. I could use StringBuilder but since it is small and not offten operation, i simply make it that way
            string cost = "Drzewo: " + woodCost.ToString() + "   Pieniądze: " + moneyCost.ToString();
            return cost;
        }

        /// <summary>
        /// Getter for farmsCount
        /// </summary>
        /// <returns>Number of farms</returns>
        public static int GetFarmsCount()
        {
            return farmsCount;
        }

        /// <summary>
        /// Getter for baseProduction
        /// </summary>
        /// <returns></returns>
        public static int GetBaseProduction()
        {
            return baseProduction;
        }
    }
}