namespace ArkadiuszCichylab1HomeWork
{
    /// <summary>
    /// Static class that manages player's Castle, it's level and other properties
    /// </summary>
    public static class Castle
    {
        private static int castleLevel = 1;                         // Level of player's castle
        private static int woodCost = 60 * castleLevel;             // How much wood castle cost
        private static int stoneCost = 40 * (castleLevel - 1);      // How much stone castle cost
        private static int gemsCost = 20 * (castleLevel - 1);       // How much gems castle cost
        private static int moneyCost = 800 * castleLevel;           // How much money castle cost
        private static int foodIncomeCost = 5 * (castleLevel - 1);  // How much food castle consumes per tick
        private static int baseProduction = 50 * castleLevel;      // How much money castle products

        /// <summary>
        /// Checking if player has enough resources to upgrade castle
        /// </summary>
        /// <param name="playersWood">Ammount of player's wood</param>
        /// <param name="playersStone">Ammount of player's stone</param>
        /// <param name="playersGems">Ammount of player's gems</param>
        /// <param name="playersMoney">Ammount of player's money</param>
        /// <returns>True if building is avalible</returns>
        public static bool ResourceCheck(ref int playersWood, ref int playersStone, ref int playersGems, ref int playersMoney)
        {
            if (playersWood >= woodCost && playersStone >= stoneCost && playersGems >= gemsCost && playersMoney >= moneyCost)
            {
                playersWood -= woodCost;
                playersStone -= stoneCost;
                playersGems -= gemsCost;
                playersMoney -= moneyCost;
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Increase castle level
        /// </summary>
        public static void Build()
        {
            // Updating costs
            woodCost = 60 * castleLevel;             // How much wood castle cost
            stoneCost = 40 * (castleLevel - 1);      // How much stone castle cost
            gemsCost = 20 * (castleLevel - 1);       // How much gems castle cost
            moneyCost = 800 * castleLevel;           // How much money castle cost
            foodIncomeCost = 5 * (castleLevel - 1);  // How much food castle consumes per tick
            ++castleLevel;
            baseProduction = 50 * castleLevel;      // How much money castle produces
        }

        /// <summary>
        /// Decrase castle level
        /// </summary>
        public static void Destroy()
        {
            --castleLevel;

            // Updating costs
            woodCost = 60 * castleLevel;             // How much wood castle cost
            stoneCost = 40 * (castleLevel - 1);      // How much stone castle cost
            gemsCost = 20 * (castleLevel - 1);       // How much gems castle cost
            moneyCost = 800 * castleLevel;           // How much money castle cost
            foodIncomeCost = 5 * (castleLevel - 1);  // How much food castle consumes per tick
            baseProduction = 50 * castleLevel;      // How much money castle products
        }

        /// <summary>
        /// Get total cost of castle
        /// </summary>
        /// <returns>Total cost of castle</returns>
        public static string GetCost()
        {
            // Building string for output. I could use StringBuilder but since it is small and not offten operation, i simply make it that way
            string cost = "Drzewo: " + woodCost.ToString() +
                "   Kamień:" + stoneCost.ToString() +
                "   Klejnoty:" + gemsCost.ToString() +
                "   Pieniądze: " + moneyCost.ToString() +
                "   Jedzenie/tick:" + foodIncomeCost.ToString();
            return cost;
        }

        /// <summary>
        /// Getter for castleLevel
        /// </summary>
        /// <returns>Castle Level</returns>
        public static int GetLevel()
        {
            return castleLevel;
        }

        /// <summary>
        /// Getter for foodIncomeCost
        /// </summary>
        /// <returns>Food income cost</returns>
        public static int GetFoodIncomeCost()
        {
            return foodIncomeCost;
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