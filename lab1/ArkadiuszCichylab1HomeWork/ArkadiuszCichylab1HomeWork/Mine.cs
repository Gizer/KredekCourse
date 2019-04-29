namespace ArkadiuszCichylab1HomeWork
{
    /// <summary>
    /// Static class that manages all mines and their properties
    /// </summary>
    public static class Mine
    {
        private const int woodCost = 60;        // How much wood mine cost
        private const int stoneCost = 20;       // How much stone mine cost
        private const int moneyCost = 500;      // How much money mine cost
        private const int foodIncomeCost = 5;   // How much food mine consumes per tick
        private const int baseProduction = 1;   // How much one mine products
        private static int minesCount = 0;      // How many mines there are

        /// <summary>
        /// Checking if player has enough resources to build mine
        /// </summary>
        /// <param name="playersWood">Ammount of player's wood</param>
        /// <param name="playersStone">Ammount of player's stone</param>
        /// <param name="playersMoney">Ammount of player's money</param>
        /// <returns>True if building is avalible</returns>
        public static bool ResourcesCheck(ref int playersWood, ref int playersStone, ref int playersMoney)
        {
            if (playersWood >= woodCost && playersStone >= stoneCost && playersMoney >= moneyCost)
            {
                playersWood -= woodCost;
                playersStone -= stoneCost;
                playersMoney -= moneyCost;
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Increase number of mines due to player's action
        /// </summary>
        public static void Build()
        {
            ++minesCount;
        }

        /// <summary>
        /// Decrase number of mines due to player's actions or events
        /// </summary>
        public static void Destroy()
        {
            --minesCount;
        }

        /// <summary>
        /// Returns total cost for mine
        /// </summary>
        /// <returns>Total cost for mine</returns>
        public static string GetCost()
        {
            // Building string for output. I could use StringBuilder but since it is small and not offten operation, i simply make it that way
            string cost = "Drzewo: " + woodCost.ToString() +
                "   Kamień:" + stoneCost.ToString() +
                "   Pieniądze: " + moneyCost.ToString() +
                "   Jedzenie/tick:" + foodIncomeCost.ToString();
            return cost;
        }

        /// <summary>
        /// Getter for minesCOunt
        /// </summary>
        /// <returns>Number of mines</returns>
        public static int GetMinesCount()
        {
            return minesCount;
        }

        /// <summary>
        /// Getter for foodIncomeCost
        /// </summary>
        /// <returns>Food income cost</returns>
        public static int GetFoodIncomeCost()
        {
            return foodIncomeCost * minesCount;
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