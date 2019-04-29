namespace ArkadiuszCichylab1HomeWork
{
    /// <summary>
    /// Static class that manages all sawmills and their properties
    /// </summary>
    public static class Sawmill
    {
        private const int woodCost = 15;        // How much wood sawmill cost
        private const int moneyCost = 100;      // How much money sawmill cost
        private const int baseProduction = 5;   // How much one sawmill products
        private static int sawmillCount = 0;   // How many sawmills there are

        /// <summary>
        /// Checking if player has enough resources to build sawmill
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
        /// Increase number of sawmills due to player's actions
        /// </summary>
        public static void Build()
        {
            ++sawmillCount;
        }

        /// <summary>
        /// Decrase number of sawmills due to player's actions or events
        /// </summary>
        public static void Destroy()
        {
            --sawmillCount;
        }

        /// <summary>
        /// Returns total cost for sawmill
        /// </summary>
        /// <returns>Total cost for sawmill</returns>
        public static string GetCost()
        {
            // Building string for output. I could use StringBuilder but since it is small and not offten operation, i simply make it that way
            string cost = "Drzewo: " + woodCost.ToString() + "   Pieniądze: " + moneyCost.ToString();
            return cost;
        }

        /// <summary>
        /// Getter for sawmillsCount
        /// </summary>
        /// <returns>Number of sawmills</returns>
        public static int GetSawmillsCount()
        {
            return sawmillCount;
        }

        /// <summary>
        /// Getter for baseProduction
        /// </summary>
        /// <returns>Base production</returns>
        public static int GetBaseProduction()
        {
            return baseProduction;
        }
    }
}