namespace ArkadiuszCichylab1HomeWork
{
    /// <summary>
    /// Static class that manages all quarries and their properties
    /// </summary>
    public static class Quarry
    {
        private const int woodCost = 35;        // How much wood quarry cost
        private const int moneyCost = 250;      // How much money quarry cost
        private const int foodIncomeCost = 1;   // How much food quarry consumes per tick
        private const int baseProduction = 2;   // How much one quarry products
        private static int quarriesCount = 0;   // How many quarries there are

        /// <summary>
        /// Checking if player has enough resources to build quarry
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
        /// Increase number of quarries due to player's action
        /// </summary>
        public static void Build()
        {
            ++quarriesCount;
        }

        /// <summary>
        /// Decrase number of quarries due to player's actions or events
        /// </summary>
        public static void Destroy()
        {
            --quarriesCount;
        }

        /// <summary>
        /// Returns total cost for quarry
        /// </summary>
        /// <returns>Total cost for quarry</returns>
        public static string GetCost()
        {
            // Building string for output. I could use StringBuilder but since it is small and not offten operation, i simply make it that way
            string cost = "Drzewo: " + woodCost.ToString() +
                "   Pieniądze: " + moneyCost.ToString() +
                "   Jedzenie/tick:" + foodIncomeCost.ToString();
            return cost;
        }

        /// <summary>
        /// Getter for quarriesCount
        /// </summary>
        /// <returns>Number of quarries</returns>
        public static int GetQuarriesCount()
        {
            return quarriesCount;
        }

        /// <summary>
        /// Getter for foodIncomeCost
        /// </summary>
        /// <returns>Food income cost</returns>
        public static int GetFoodIncomeCost()
        {
            return foodIncomeCost * quarriesCount;
        }

        /// <summary>
        /// Getter for baseProduction
        /// </summary>
        /// <returns>Base Production</returns>
        public static int GetBaseProduction()
        {
            return baseProduction;
        }
    }
}